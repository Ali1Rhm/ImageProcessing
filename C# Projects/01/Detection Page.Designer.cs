namespace _01
{
    partial class Detection_Page
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
            label2 = new Label();
            label1 = new Label();
            picbox_detected = new PictureBox();
            picbox_main = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picbox_detected).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbox_main).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 315);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 8;
            label2.Text = "Detected";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 315);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 7;
            label1.Text = "Main";
            // 
            // picbox_detected
            // 
            picbox_detected.BackgroundImage = Properties.Resources.general_img_square;
            picbox_detected.BackgroundImageLayout = ImageLayout.Stretch;
            picbox_detected.BorderStyle = BorderStyle.Fixed3D;
            picbox_detected.Location = new Point(322, 12);
            picbox_detected.Name = "picbox_detected";
            picbox_detected.Size = new Size(300, 300);
            picbox_detected.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox_detected.TabIndex = 6;
            picbox_detected.TabStop = false;
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
            picbox_main.TabIndex = 5;
            picbox_main.TabStop = false;
            // 
            // Detection_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 361);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picbox_detected);
            Controls.Add(picbox_main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Detection_Page";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detection Page";
            ((System.ComponentModel.ISupportInitialize)picbox_detected).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbox_main).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox picbox_detected;
        private PictureBox picbox_main;
    }
}