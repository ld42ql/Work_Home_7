using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_2
{
    public partial class Form1 : Form
    {
        Game game = new Game();

        public Form1()
        {
            InitializeComponent();
            lblError.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblInfo.Text = $"Компьютер загадывает число в диапазоне от 1 до 100,\nа человек за " +
                $"ограниченное число попыток должен угадать число.";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                click();
            }

            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.KeyChar = (Char)0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (int.Parse(textBox1.Text) > 100)
                {
                    lblError.Visible = true;
                    lblError.Text = "Напоминаю правила, загадоное число не может быть \nбольше 100!!!";
                }
                else
                {
                    lblError.Visible = false;
                    game.UserNumber = int.Parse(textBox1.Text);
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            click();
        }

        private void click()
        {
            if (game.Flag)
            {
                lblInfo.Text = game.GuessGame();
                textBox1.Clear();
                textBtn();
            }
            else
            {
                DialogResult result = MessageBox.Show("Заново?", "Игра окончена", MessageBoxButtons.OKCancel );
                
                if (result == DialogResult.OK)
                {
                    lblInfo.Text = $"Компьютер загадывает число в диапазоне от 1 до 100,\nа человек за " +
                $"ограниченное число попыток должен угадать число.";
                    game.NextGame();
                    textBtn();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void textBtn()
        {
            switch (game.Count)
            {
                case 0: btn.Text = "Начали заново"; break;
                case 1: btn.Text = "Попробую ещё раз"; break;
                case 3: btn.Text = "Теперь точно повезет"; break;
                case 5: btn.Text = "Я уверен, в этом числе"; break;
                case 8: btn.Text = "Это моя последняя попытка"; break;
                case 9: btn.Text = "У меня больше нет попыток"; break;
                default: btn.Text = "Наверно, это число загадали"; break;
            }
        }
    }
}
