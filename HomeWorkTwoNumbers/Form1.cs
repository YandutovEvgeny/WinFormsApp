using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkTwoNumbers
{
    public partial class Form1 : Form
    {
        double firstNumber, secondNumber, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                secondNumber = Convert.ToDouble(textBox2.Text);
                NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
                {
                    NumberDecimalSeparator = ".",
                };
                result = firstNumber + secondNumber;
                MessageBox.Show(result.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректные данные!");
            }
        }
    }
}
