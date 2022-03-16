using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTakToe
{
    public partial class Form1 : Form
    {
        bool isCross = true;
        public Form1()
        {
            InitializeComponent();
        }

        void Button_Click(object sender, EventArgs e)
        {
            //object sender - это тот объект с которым мы взаимодействуем в данное время
            Button button = (Button)sender;
            if(button.Text == "")
            {

                if(isCross == true)
                {
                    button.ForeColor = Color.Red;
                    button.Text = "X";
                }
                else
                {
                    button.ForeColor = Color.Blue;
                    button.Text = "O";
                }
                isCross = !isCross;
            }
        }

        
    }
}
