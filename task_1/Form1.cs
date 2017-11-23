using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

            Game.StartGame();
            hideInterface();
            DisplayCurrentNum();
        }

        private void btnCommand1_MouseClick(object sender, MouseEventArgs e)
        {
            Game.OperationGame(Doubler.IncreaseValue);
            DisplayCurrentNum();
        }

        private void btnCommand2_MouseClick(object sender, MouseEventArgs e)
        {
            Game.OperationGame(Doubler.MultValue);
            DisplayCurrentNum();
        }

        private void btnReset_MouseClick(object sender, MouseEventArgs e)
        {
            Game.OperationGame(Doubler.ResetValue);
            DisplayCurrentNum();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Game.OperationGame(Doubler.ReturnValue);
            DisplayCurrentNum();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            viewInterface();
        }

        

        /// <summary>
        /// Показать изменение значений
        /// </summary>
        public void DisplayCurrentNum()
        {
            if (Game.Current >= Game.FinishGame)
            {
                MessageBox.Show(Game.Result(), $"Уровень: {Game.lvl}");
                Game.StartGame();
            }
            lblCount.Text = $"Сделано шагов: {Doubler.Count}";
            lblNumber.Text = $"Ваше число: {Game.Current}";
            lblFinish.Text = $"Достичь число {Game.FinishGame}";
        }

        /// <summary>
        /// Скрыть игровой интерфейс, показать описание игры
        /// </summary>
        private void hideInterface()
        {
            btnCommand1.Visible = false;
            btnCommand2.Visible = false;
            btnReset.Visible = false;
            btnReturn.Visible = false;
            lblCount.Visible = false;
            lblFinish.Visible = false;
            lblNumber.Visible = false;
            txtInfo.Text = $"В этой игре Вам необходимо управляя роботом \"Удвоитель\" достичь числа" +
                $" {Game.FinishGame} за минимальное число шагов.\nВы начинаете с {Game.Current}.\n" +
                $"\nРобот умеет выполнять несколько команд: \nувеличить число на 1; \nумножить число на 2;" +
                $"  \nсбросить число до 1.";
        }

      

        private void viewInterface()
        {
            btnCommand1.Visible = true;
            btnCommand2.Visible = true;
            btnReset.Visible = true;
            btnReturn.Visible = true;
            lblCount.Visible = true;
            lblFinish.Visible = true;
            lblNumber.Visible = true;
            txtInfo.Visible = false;
            btnStart.Visible = false;
        }

        
    }
}
