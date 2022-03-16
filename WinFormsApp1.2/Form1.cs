using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1._2
{
    public partial class Form1 : Form
    {
        double height, weight, imt;
        string result;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                height = Convert.ToDouble(textBox1.Text);
                weight = Convert.ToDouble(textBox3.Text);
                height = Math.Abs(height);  //Модуль числа
                Width = Math.Abs(Width);
                height /= 100;
                imt = weight / (height * height);
                if (imt <= 16) result = "Выраженный дефицит массы тела";
                else if (imt > 16 && imt <= 18.5) result = "Недостаточная масса тела(дефицит)";
                else if (imt > 18.5 && imt <= 25) result = "Норма";
                else if (imt > 25 && imt <= 30) result = "Избыточная масса тела(состояние, предшествующее ожирению)";
                else if (imt > 30 && imt <= 35) result = "Ожирение 1 - й степени";
                else if (imt > 35 && imt <= 40) result = "Ожирение 2 - й степени";
                else result = "Ожирение 3 - й степени";
            }
            catch (Exception)
            {

                result = "Введены не верные данные";
            }
            MessageBox.Show(result);
        }
    }
}
