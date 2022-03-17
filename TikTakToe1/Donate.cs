using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TikTakToe1
{
    public partial class Donate : Form
    {
        public Donate()
        {
            InitializeComponent();
        }

        private void Donate_Load(object sender, EventArgs e)
        {
            label1.Text = "Сбербанк 2490 3467 6378 2405 \n" +
                "Kiwi 5698 2396 64 2386 \n" + "Номер телефона +89875764385";
        }
    }
}
