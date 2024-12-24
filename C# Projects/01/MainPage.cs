namespace _01
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picbox_display.Image = Bitmap.FromFile(ofd.FileName);

                if (picbox_display.Image != null)
                {
                    btn_grayscale.Enabled = true;
                    btn_rgb.Enabled = true;
                    btn_cmy.Enabled = true;
                    btn_yuv.Enabled = true;
                    btn_hls.Enabled = true;
                    btn_detectskin.Enabled = true;
                    btn_detectredeye.Enabled = true;
                }
            }
        }

        private void btn_grayscale_Click(object sender, EventArgs e)
        {
            GrayscalePage grayscalePage = new GrayscalePage();

            Bitmap formulated = ImageProcessing.FormulatedGrayscale((Bitmap)picbox_display.Image);
            Bitmap library = ImageProcessing.LibraryGrayscale((Bitmap)picbox_display.Image);

            float diff = ImageProcessing.GetBitmapDifference(formulated, library);

            grayscalePage.PicBox_Grayscale.Image = formulated;
            grayscalePage.Picbox_Lib_Grayscale.Image = library;
            grayscalePage.Lbl_Diff.Text = $"Difference: {diff:N0}%";

            grayscalePage.ShowDialog();
        }

        private void btn_rgb_Click(object sender, EventArgs e)
        {
            Channels_Page channels_Page = new Channels_Page();

            Bitmap rChannel;
            Bitmap gChannel;
            Bitmap bChannel;
            ImageProcessing.SeperateRGBChannels((Bitmap)picbox_display.Image, out rChannel, out gChannel, out bChannel);

            channels_Page.Main.Image = (Bitmap)picbox_display.Image;
            channels_Page.Channel_01.Image = rChannel;
            channels_Page.Channel_02.Image = gChannel;
            channels_Page.Channel_03.Image = bChannel;

            channels_Page.ShowDialog();
        }

        private void btn_cmy_Click(object sender, EventArgs e)
        {
            Channels_Page channels_Page = new Channels_Page();

            Bitmap cChannel;
            Bitmap mChannel;
            Bitmap yChannel;
            ImageProcessing.SeperateCMYChannels((Bitmap)picbox_display.Image, out cChannel, out mChannel, out yChannel);

            channels_Page.Main.Image = (Bitmap)picbox_display.Image;
            channels_Page.Channel_01.Image = cChannel;
            channels_Page.Channel_02.Image = mChannel;
            channels_Page.Channel_03.Image = yChannel;

            channels_Page.ShowDialog();
        }

        private void btn_yuv_Click(object sender, EventArgs e)
        {
            Channels_Page channels_Page = new Channels_Page();

            Bitmap yChannel;
            Bitmap uChannel;
            Bitmap vChannel;
            ImageProcessing.SeperateYUVChannels((Bitmap)picbox_display.Image, out yChannel, out uChannel, out vChannel);

            channels_Page.Main.Image = (Bitmap)picbox_display.Image;
            channels_Page.Channel_01.Image = yChannel;
            channels_Page.Channel_02.Image = uChannel;
            channels_Page.Channel_03.Image = vChannel;

            channels_Page.ShowDialog();
        }

        private void btn_hls_Click(object sender, EventArgs e)
        {
            Channels_Page channels_Page = new Channels_Page();

            Bitmap hChannel;
            Bitmap lChannel;
            Bitmap sChannel;
            ImageProcessing.SeperateHLSChannels((Bitmap)picbox_display.Image, out hChannel, out lChannel, out sChannel);

            channels_Page.Main.Image = (Bitmap)picbox_display.Image;
            channels_Page.Channel_01.Image = hChannel;
            channels_Page.Channel_02.Image = lChannel;
            channels_Page.Channel_03.Image = sChannel;

            channels_Page.ShowDialog();
        }

        private void btn_detectskin_Click(object sender, EventArgs e)
        {
            Detection_Page detection_Page = new Detection_Page();

            Bitmap main = (Bitmap)picbox_display.Image;
            Bitmap detected = ImageProcessing.DetectSkin(main);

            detection_Page.PicBox_Main.Image = main;
            detection_Page.PicBox_Detected.Image = detected;

            detection_Page.ShowDialog();
        }

        private void btn_detectredeye_Click(object sender, EventArgs e)
        {
            Detection_Page detection_Page = new Detection_Page();

            Bitmap main = (Bitmap)picbox_display.Image;
            Bitmap detected = ImageProcessing.DetectRedEye(main);

            detection_Page.PicBox_Main.Image = main;
            detection_Page.PicBox_Detected.Image = detected;

            detection_Page.ShowDialog();
        }
    }
}
