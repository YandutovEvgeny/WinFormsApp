using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            panel1.Width = trackBar1.Value + 100;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            panel1.Height = trackBar2.Value + 100;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb
                (trackBar3.Value, trackBar4.Value, trackBar5.Value);
        }
    }
}
