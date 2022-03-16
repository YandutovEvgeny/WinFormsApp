using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_1
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
            count++;
            //button1.Text = count.ToString();    //Текст в кнопке
            label1.Text = count.ToString(); //Текст в лейбле. Метод ToString() делает из int string

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            button1.Left = random.Next(Width - button1.Width);    //Ось y
            button1.Top = random.Next(Height - button1.Height);   //Ось x
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (Width < button1.Left + button1.Width) button1.Left = Width - button1.Width;
            if (Height < button1.Height + button1.Height) button1.Top = Height - button1.Height;
        }
    }
}
