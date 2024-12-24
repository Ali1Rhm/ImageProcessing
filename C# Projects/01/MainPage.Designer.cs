namespace _01
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picbox_display = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_select = new Button();
            btn_grayscale = new Button();
            btn_rgb = new Button();
            btn_cmy = new Button();
            btn_yuv = new Button();
            btn_hls = new Button();
            btn_detectskin = new Button();
            btn_detectredeye = new Button();
            ((System.ComponentModel.ISupportInitialize)picbox_display).BeginInit();
            SuspendLayout();
            // 
            // picbox_display
            // 
            picbox_display.BackgroundImage = Properties.Resources.general_img_square;
            picbox_display.BackgroundImageLayout = ImageLayout.Stretch;
            picbox_display.BorderStyle = BorderStyle.Fixed3D;
            picbox_display.Location = new Point(12, 12);
            picbox_display.Name = "picbox_display";
            picbox_display.Size = new Size(400, 400);
            picbox_display.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox_display.TabIndex = 0;
            picbox_display.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 430);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 1;
            label1.Text = "Developer: Ali Rahimpour";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 430);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Mentor: Dr. Asadi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 415);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 3;
            label3.Text = "CV_1403_1";
            // 
            // btn_select
            // 
            btn_select.Location = new Point(527, 12);
            btn_select.Name = "btn_select";
            btn_select.Size = new Size(180, 45);
            btn_select.TabIndex = 4;
            btn_select.Text = "Select Picture";
            btn_select.UseVisualStyleBackColor = true;
            btn_select.Click += btn_select_Click;
            // 
            // btn_grayscale
            // 
            btn_grayscale.Enabled = false;
            btn_grayscale.Location = new Point(527, 63);
            btn_grayscale.Name = "btn_grayscale";
            btn_grayscale.Size = new Size(180, 45);
            btn_grayscale.TabIndex = 5;
            btn_grayscale.Text = "Make Grayscale";
            btn_grayscale.UseVisualStyleBackColor = true;
            btn_grayscale.Click += btn_grayscale_Click;
            // 
            // btn_rgb
            // 
            btn_rgb.Enabled = false;
            btn_rgb.Location = new Point(527, 114);
            btn_rgb.Name = "btn_rgb";
            btn_rgb.Size = new Size(180, 45);
            btn_rgb.TabIndex = 6;
            btn_rgb.Text = "RGB Info";
            btn_rgb.UseVisualStyleBackColor = true;
            btn_rgb.Click += btn_rgb_Click;
            // 
            // btn_cmy
            // 
            btn_cmy.Enabled = false;
            btn_cmy.Location = new Point(527, 165);
            btn_cmy.Name = "btn_cmy";
            btn_cmy.Size = new Size(180, 45);
            btn_cmy.TabIndex = 7;
            btn_cmy.Text = "CMY Info";
            btn_cmy.UseVisualStyleBackColor = true;
            btn_cmy.Click += btn_cmy_Click;
            // 
            // btn_yuv
            // 
            btn_yuv.Enabled = false;
            btn_yuv.Location = new Point(527, 216);
            btn_yuv.Name = "btn_yuv";
            btn_yuv.Size = new Size(180, 45);
            btn_yuv.TabIndex = 8;
            btn_yuv.Text = "YUV Info";
            btn_yuv.UseVisualStyleBackColor = true;
            btn_yuv.Click += btn_yuv_Click;
            // 
            // btn_hls
            // 
            btn_hls.Enabled = false;
            btn_hls.Location = new Point(527, 267);
            btn_hls.Name = "btn_hls";
            btn_hls.Size = new Size(180, 45);
            btn_hls.TabIndex = 9;
            btn_hls.Text = "HLS Info";
            btn_hls.UseVisualStyleBackColor = true;
            btn_hls.Click += btn_hls_Click;
            // 
            // btn_detectskin
            // 
            btn_detectskin.Enabled = false;
            btn_detectskin.Location = new Point(527, 318);
            btn_detectskin.Name = "btn_detectskin";
            btn_detectskin.Size = new Size(180, 45);
            btn_detectskin.TabIndex = 10;
            btn_detectskin.Text = "Detect Skin";
            btn_detectskin.UseVisualStyleBackColor = true;
            btn_detectskin.Click += btn_detectskin_Click;
            // 
            // btn_detectredeye
            // 
            btn_detectredeye.Enabled = false;
            btn_detectredeye.Location = new Point(527, 369);
            btn_detectredeye.Name = "btn_detectredeye";
            btn_detectredeye.Size = new Size(180, 45);
            btn_detectredeye.TabIndex = 11;
            btn_detectredeye.Text = "Detect Red Eye";
            btn_detectredeye.UseVisualStyleBackColor = true;
            btn_detectredeye.Click += btn_detectredeye_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_detectredeye);
            Controls.Add(btn_detectskin);
            Controls.Add(btn_hls);
            Controls.Add(btn_yuv);
            Controls.Add(btn_cmy);
            Controls.Add(btn_rgb);
            Controls.Add(btn_grayscale);
            Controls.Add(btn_select);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picbox_display);
            Name = "MainPage";
            Text = "Main Page";
            ((System.ComponentModel.ISupportInitialize)picbox_display).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picbox_display;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_select;
        private Button btn_grayscale;
        private Button btn_rgb;
        private Button btn_cmy;
        private Button btn_yuv;
        private Button btn_hls;
        private Button btn_detectskin;
        private Button btn_detectredeye;
    }
}