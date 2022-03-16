using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;    //При нажатии кнопки счётчик увеличивается
            label1.Text = count.ToString();    //Метод ToString переводит тип данных int в string 
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            button1.Left = random.Next(Width - button1.Width);
            button1.Top = random.Next(Height - button1.Height);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if(Width < button1.Left + button1.Width)
            {
                button1.Left = Width - button1.Width;
            }
            if(Height < button1.Top + button1.Height)
            {
                button1.Top = Height - button1.Height;
            }
        }
    }
}
