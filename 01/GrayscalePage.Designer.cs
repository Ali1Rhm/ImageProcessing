namespace _01
{
    partial class GrayscalePage
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
            picbox_grayscale = new PictureBox();
            picbox_lib_grayscale = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lbl_diff = new Label();
            ((System.ComponentModel.ISupportInitialize)picbox_grayscale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbox_lib_grayscale).BeginInit();
            SuspendLayout();
            // 
            // picbox_grayscale
            // 
            picbox_grayscale.BackgroundImage = Properties.Resources.general_img_square;
            picbox_grayscale.BackgroundImageLayout = ImageLayout.Stretch;
            picbox_grayscale.BorderStyle = BorderStyle.Fixed3D;
            picbox_grayscale.Location = new Point(12, 9);
            picbox_grayscale.Name = "picbox_grayscale";
            picbox_grayscale.Size = new Size(300, 300);
            picbox_grayscale.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox_grayscale.TabIndex = 1;
            picbox_grayscale.TabStop = false;
            // 
            // picbox_lib_grayscale
            // 
            picbox_lib_grayscale.BackgroundImage = Properties.Resources.general_img_square;
            picbox_lib_grayscale.BackgroundImageLayout = ImageLayout.Stretch;
            picbox_lib_grayscale.BorderStyle = BorderStyle.Fixed3D;
            picbox_lib_grayscale.Location = new Point(322, 9);
            picbox_lib_grayscale.Name = "picbox_lib_grayscale";
            picbox_lib_grayscale.Size = new Size(300, 300);
            picbox_lib_grayscale.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox_lib_grayscale.TabIndex = 2;
            picbox_lib_grayscale.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 312);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 3;
            label1.Text = "Formulated";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 312);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 4;
            label2.Text = "Library (EmguCV)";
            // 
            // lbl_diff
            // 
            lbl_diff.AutoSize = true;
            lbl_diff.Location = new Point(527, 337);
            lbl_diff.Name = "lbl_diff";
            lbl_diff.Size = new Size(95, 15);
            lbl_diff.TabIndex = 5;
            lbl_diff.Text = "Difference: 100%";
            // 
            // GrayscalePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 361);
            Controls.Add(lbl_diff);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picbox_lib_grayscale);
            Controls.Add(picbox_grayscale);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "GrayscalePage";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Grayscale Page";
            ((System.ComponentModel.ISupportInitialize)picbox_grayscale).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbox_lib_grayscale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picbox_grayscale;
        private PictureBox picbox_lib_grayscale;
        private Label label1;
        private Label label2;
        private Label lbl_diff;
    }
}