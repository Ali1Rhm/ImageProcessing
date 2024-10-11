using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01
{
    public partial class GrayscalePage : Form
    {
        public PictureBox PicBox_Grayscale { get { return picbox_grayscale; } set { picbox_grayscale = value; } }
        public PictureBox Picbox_Lib_Grayscale { get { return picbox_lib_grayscale; } set { picbox_lib_grayscale = value; } }
        public Label Lbl_Diff { get { return lbl_diff; } set { lbl_diff = value; } }

        public GrayscalePage()
        {
            InitializeComponent();
        }
    }
}
