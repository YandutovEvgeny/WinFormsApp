using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTakToe1
{
    public partial class Form1 : Form
    {
        bool isCross = true;    //Ходят крестики
        int count = 0;          //Количество ходов
        public Form1()
        {
            InitializeComponent();
        }

        void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; //Явно приводим тип object в тип Button, чтобы 
                                            //программа понимала с какой кнопкой должна работать
            if(button.Text == "" && !isWinner())
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
                count++;    
                if (isWinner())
                {
                    if (isCross) MessageBox.Show("Победили крестики");
                    else MessageBox.Show("Победили нолики");
                }
                else if (count >= 9) MessageBox.Show("Ничья");
                isCross = !isCross;
            }
        }

        bool isWinner()
        {
            //Горизонтальные линии
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") return true;
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") return true;
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "") return true;

            //Вертикальные линии
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") return true;
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") return true;
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "") return true;

            //Диагональные линии
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") return true;
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "") return true;
           
            return false;
        }

        void newGame()      //Новая игра
        {
            isCross = true;
            count = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }   

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();    //Функция Close() закрывает окно
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void оСоздателяхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            //about.Show();     //Show() показывает не модальное окно
            about.ShowDialog(); //ShowDialog() делает диалоговое окно модальным
        }

        private void донатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donate donate = new Donate();
            donate.ShowDialog();
        }
    }
}
