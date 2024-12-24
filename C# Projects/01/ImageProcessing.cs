using Emgu.CV.Structure;
using Emgu.CV;

namespace _01
{
    public static class ImageProcessing
    {
        public static Bitmap FormulatedGrayscale(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap);

            Color currentPixel;
            byte grayscale;

            for (int i = 0; i < result.Width; i++)
            {
                for (int j = 0; j < result.Height; j++)
                {
                    currentPixel = result.GetPixel(i, j);
                    grayscale = (byte)(0.299f * currentPixel.R + 0.587f * currentPixel.G + 0.114f * currentPixel.B);
                    result.SetPixel(i, j, Color.FromArgb(grayscale, grayscale, grayscale));
                }
            }

            return result;
        }

        public static Bitmap LibraryGrayscale(Bitmap bitmap)
        {
            Image<Bgr, Byte> image = new Image<Bgr, Byte>(bitmap.ToMat());

            return image.Convert<Gray, Byte>().ToBitmap();
        }

        public static float GetBitmapDifference(Bitmap bitmap1, Bitmap bitmap2)
        {
            if (bitmap1.Width != bitmap2.Width || bitmap1.Height != bitmap2.Height)
                return 100;

            float differences = 0;
            Color pixel1, pixel2;

            for (int i = 0; i < bitmap1.Width; i++)
            {
                for (int j = 0; j < bitmap1.Height; j++)
                {
                    pixel1 = bitmap1.GetPixel(i, j);
                    pixel2 = bitmap2.GetPixel(i, j);

                    if (pixel1.R - pixel2.R == 0 &&
                        pixel1.G - pixel2.G == 0 &&
                        pixel1.B - pixel2.B == 0)
                        continue;

                    differences++;
                }
            }

            float totalPixels = (bitmap1.Width * bitmap1.Height);

            return (differences / totalPixels) * 100f;
        }

        public static void SeperateRGBChannels(Bitmap bitmap, out Bitmap rChannel, out Bitmap gChannel, out Bitmap bChannel)
        {
            rChannel = new Bitmap(bitmap.Width, bitmap.Height);
            gChannel = new Bitmap(bitmap.Width, bitmap.Height);
            bChannel = new Bitmap(bitmap.Width, bitmap.Height);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    var currentPixel = bitmap.GetPixel(i, j);

                    rChannel.SetPixel(i, j, Color.FromArgb(currentPixel.R, currentPixel.R, currentPixel.R));
                    gChannel.SetPixel(i, j, Color.FromArgb(currentPixel.G, currentPixel.G, currentPixel.G));
                    bChannel.SetPixel(i, j, Color.FromArgb(currentPixel.B, currentPixel.B, currentPixel.B));
                }
            }
        }

        public static void SeperateCMYChannels(Bitmap bitmap, out Bitmap cChannel, out Bitmap mChannel, out Bitmap yChannel)
        {
            cChannel = new Bitmap(bitmap.Width, bitmap.Height);
            mChannel = new Bitmap(bitmap.Width, bitmap.Height);
            yChannel = new Bitmap(bitmap.Width, bitmap.Height);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    var currentPixel = bitmap.GetPixel(i, j);

                    cChannel.SetPixel(i, j, Color.FromArgb(255 - currentPixel.R, 255 - currentPixel.R, 255 - currentPixel.R));
                    mChannel.SetPixel(i, j, Color.FromArgb(255 - currentPixel.G, 255 - currentPixel.G, 255 - currentPixel.G));
                    yChannel.SetPixel(i, j, Color.FromArgb(255 - currentPixel.B, 255 - currentPixel.B, 255 - currentPixel.B));
                }
            }
        }

        public static void SeperateYUVChannels(Bitmap bitmap, out Bitmap yChannel, out Bitmap uChannel, out Bitmap vChannel)
        {
            yChannel = new Bitmap(bitmap.Width, bitmap.Height);
            uChannel = new Bitmap(bitmap.Width, bitmap.Height);
            vChannel = new Bitmap(bitmap.Width, bitmap.Height);

            double y, u, v;
            double rNorm, gNorm, bNorm;
            int yComponent, uComponent, vComponent;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    var currentPixel = bitmap.GetPixel(i, j);

                    rNorm = currentPixel.R / 255.0;
                    gNorm = currentPixel.G / 255.0;
                    bNorm = currentPixel.B / 255.0;

                    y = (0.299 * rNorm + 0.587 * gNorm + 0.114 * bNorm);
                    u = (0.492 * (bNorm - y));
                    v = (0.877 * (rNorm - y));

                    yComponent = (int)(y * 255);
                    uComponent = (int)((u + 0.5) * 255);
                    vComponent = (int)((v + 0.5) * 255);

                    yComponent = Math.Clamp(yComponent, 0, 255);
                    uComponent = Math.Clamp(uComponent, 0, 255);
                    vComponent = Math.Clamp(vComponent, 0, 255);

                    yChannel.SetPixel(i, j, Color.FromArgb(yComponent, yComponent, yComponent));
                    uChannel.SetPixel(i, j, Color.FromArgb(uComponent, uComponent, uComponent));
                    vChannel.SetPixel(i, j, Color.FromArgb(vComponent, vComponent, vComponent));
                }
            }
        }

        public static void SeperateHLSChannels(Bitmap bitmap, out Bitmap HChannel, out Bitmap LChannel, out Bitmap SChannel)
        {
            HChannel = new Bitmap(bitmap.Width, bitmap.Height);
            LChannel = new Bitmap(bitmap.Width, bitmap.Height);
            SChannel = new Bitmap(bitmap.Width, bitmap.Height);

            double h, l, s;

            int hComponent, lComponent, sComponent;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    var currentPixel = bitmap.GetPixel(i, j);
                    RGBtoHLS(currentPixel, out h, out l, out s);

                    hComponent = (int)(h * 255 / 360);
                    lComponent = (int)(l * 255);
                    sComponent = (int)(s * 255);

                    hComponent = Math.Clamp(hComponent, 0, 255);
                    lComponent = Math.Clamp(lComponent, 0, 255);
                    sComponent = Math.Clamp(sComponent, 0, 255);

                    HChannel.SetPixel(i, j, Color.FromArgb(hComponent, hComponent, hComponent));
                    LChannel.SetPixel(i, j, Color.FromArgb(lComponent, lComponent, lComponent));
                    SChannel.SetPixel(i, j, Color.FromArgb(sComponent, sComponent, sComponent));
                }
            }
        }

        public static Bitmap DetectSkin(Bitmap bitmap)
        {
            double h, l, s;
            Color pixel;
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    pixel = bitmap.GetPixel(i, j);
                    RGBtoHLS(pixel, out h, out l, out s);

                    if (s >= 0.2 && (0.5 < (l / s) && (l / s) < 3.0) && (h <= 28 || h > 330))
                    {
                        result.SetPixel(i, j, pixel);
                    }
                    else
                    {
                        result.SetPixel(i, j, Color.Black);
                    }
                }
            }

            return result;
        }

        public static Bitmap DetectRedEye(Bitmap bitmap)
        {
            double h, l, s;
            int grayscale;
            Color pixel;
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    pixel = bitmap.GetPixel(i, j);
                    RGBtoHLS(pixel, out h, out l, out s);

                    if ((l >= 0.25) && (s >= 0.4) && (0.5 < (l / s) && (l / s) < 1.5) && (h <= 14 || h >= 324))
                    {
                        result.SetPixel(i, j, pixel);
                    }
                    else
                    {
                        grayscale = (byte)(0.299f * pixel.R + 0.587f * pixel.G + 0.114f * pixel.B);
                        result.SetPixel(i, j, Color.FromArgb(grayscale, grayscale, grayscale));
                    }
                }
            }

            return result;
        }

        public static void RGBtoHLS(Color pixel, out double h, out double l, out double s)
        {
            double rNorm, gNorm, bNorm;
            double max, min, delta;

            rNorm = pixel.R / 255.0;
            gNorm = pixel.G / 255.0;
            bNorm = pixel.B / 255.0;

            max = Math.Max(rNorm, Math.Max(gNorm, bNorm));
            min = Math.Min(rNorm, Math.Min(gNorm, bNorm));
            l = (max + min) / 2.0;

            if (max == min)
            {
                h = 0;
                s = 0;
            }
            else
            {
                delta = max - min;
                s = l >= 0.5 ? delta / (2.0 - max - min) : delta / (max + min);

                if (max == rNorm)
                {
                    h = (gNorm - bNorm) / delta + (gNorm < bNorm ? 6 : 0);
                }
                else if (max == gNorm)
                {
                    h = (bNorm - rNorm) / delta + 2;
                }
                else
                {
                    h = (rNorm - gNorm) / delta + 4;
                }

                h *= 60;
            }
        }
    }
}
