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
    public partial class Channels_Page : Form
    {
        public PictureBox Main { get { return picbox_main; } set { picbox_main = value; } }
        public PictureBox Channel_01 { get { return picbox_ch01; } set { picbox_ch01 = value; } }
        public PictureBox Channel_02 { get { return picbox_ch02; } set { picbox_ch02 = value; } }
        public PictureBox Channel_03 { get { return picbox_ch03; } set { picbox_ch03 = value; } }

        public Channels_Page()
        {
            InitializeComponent();
        }
    }
}
