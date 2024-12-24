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
    public partial class Detection_Page : Form
    {
        public PictureBox PicBox_Main { get { return picbox_main; } set { picbox_main = value; } }
        public PictureBox PicBox_Detected { get { return picbox_detected; } set { picbox_detected = value; } }

        public Detection_Page()
        {
            InitializeComponent();
        }
    }
}
