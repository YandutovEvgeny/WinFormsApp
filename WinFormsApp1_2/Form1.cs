using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_2
{
    public partial class Form1 : Form
    {
        double height, weight, imt;
        string result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                height = Convert.ToDouble(textBox1.Text); //Convert.ToDouble - метод для перевода из string double 
                weight = Convert.ToDouble(textBox2.Text);
                height = Math.Abs(height);  //Модуль числа, для того, чтобы нельзя было ввести отрицательные значения
                weight = Math.Abs(weight);  //-50 -->50
                height /= 100;  //сантиметры переводим в метры
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
                result = "Введите корректные данные!";
            }
            MessageBox.Show(result);
        }
    }
}
