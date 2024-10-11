namespace _01
{
    partial class Channels_Page
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
            picbox_main = new PictureBox();
            picbox_ch01 = new PictureBox();
            picbox_ch02 = new PictureBox();
            picbox_ch03 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picbox_main).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbox_ch01).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbox_ch02).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbox_ch03).BeginInit();
            SuspendLayout();
            // 
            // picbox_main
            // 
            picbox_main.BackgroundImage = Properties.Resources.general_img_square;
            picbox_main.BackgroundImageLayout = ImageLayout.Stretch;
            picbox_main.BorderStyle = BorderStyle.Fixed3D;
            picbox_main.Location = new Point(12, 12);
            picbox_main.Name = "picbox_main";
            picbox_main.Size = new Size(300, 300);
            picbox_main.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox_main.TabIndex = 2;
            picbox_main.TabStop = false;
            // 
            // picbox_ch01
            // 
            picbox_ch01.BackgroundImage = Properties.Resources.general_img_square;
            picbox_ch01.BackgroundImageLayout = ImageLayout.Stretch;
            picbox_ch01.BorderStyle = BorderStyle.Fixed3D;
            picbox_ch01.Location = new Point(318, 12);
            picbox_ch01.Name = "picbox_ch01";
            picbox_ch01.Size = new Size(300, 300);
            picbox_ch01.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox_ch01.TabIndex = 3;
            picbox_ch01.TabStop = false;
            // 
            // picbox_ch02
            // 
            picbox_ch02.BackgroundImage = Properties.Resources.general_img_square;
            picbox_ch02.BackgroundImageLayout = ImageLayout.Stretch;
            picbox_ch02.BorderStyle = BorderStyle.Fixed3D;
            picbox_ch02.Location = new Point(12, 318);
            picbox_ch02.Name = "picbox_ch02";
            picbox_ch02.Size = new Size(300, 300);
            picbox_ch02.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox_ch02.TabIndex = 4;
            picbox_ch02.TabStop = false;
            // 
            // picbox_ch03
            // 
            picbox_ch03.BackgroundImage = Properties.Resources.general_img_square;
            picbox_ch03.BackgroundImageLayout = ImageLayout.Stretch;
            picbox_ch03.BorderStyle = BorderStyle.Fixed3D;
            picbox_ch03.Location = new Point(318, 318);
            picbox_ch03.Name = "picbox_ch03";
            picbox_ch03.Size = new Size(300, 300);
            picbox_ch03.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox_ch03.TabIndex = 5;
            picbox_ch03.TabStop = false;
            // 
            // Channels_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 631);
            Controls.Add(picbox_ch03);
            Controls.Add(picbox_ch02);
            Controls.Add(picbox_ch01);
            Controls.Add(picbox_main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Channels_Page";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Channels Page";
            ((System.ComponentModel.ISupportInitialize)picbox_main).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbox_ch01).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbox_ch02).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbox_ch03).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picbox_main;
        private PictureBox picbox_ch01;
        private PictureBox picbox_ch02;
        private PictureBox picbox_ch03;
    }
}