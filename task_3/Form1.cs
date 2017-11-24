using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_3
{
    public partial class Form1 : Form
    {
        TextBox[] txtBox = new TextBox[8];
        Label[] label = new Label[8];
        List<Shablon> list = new List<Shablon>();
        string fileStr = Shablon.OpenShablon();


        public Form1()
        {
            InitializeComponent();

            CrTxtBox();
            CrtLbl();

        }

        /// <summary>
        /// Создать восемь полей для ввода
        /// </summary>
        private void CrTxtBox()
        {
            for (int i = 0; i < txtBox.Length; i++)
            {
                txtBox[i] = new TextBox()
                {
                    Height = 150,
                    Left = 100,
                    Top = 10 + i * 20 + 5 * i,
                    Text = $""
                };
                this.Controls.Add(txtBox[i]);
            }
        }

        /// <summary>
        /// Создать восемь полей с описанием
        /// </summary>
        private void CrtLbl()
        {
            for (int j = 0; j < label.Length; j++)
            {
                label[j] = new Label()
                {
                    BackColor = Color.DarkGray,
                    BorderStyle = BorderStyle.None,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Height = 20,
                    Top = 10 + j * 20 + 5 * j,
                    Tag = $"{j}",
                    Text = $"Поля #{j + 1}"
                };
                this.Controls.Add(label[j]);
            }
        }

        /// <summary>
        /// Создаем и заполняем лист
        /// </summary>
        private void ListData()
        {
            for (int i = 0; i < 8; i++)
            {
                list.Add(new Shablon($"value{i}", txtBox[i].Text));
            }
        }
        
        /// <summary>
        /// Пройтись по листу и сделать замену
        /// </summary>
        private string RplList()
        {
            foreach (var item in list)
            {
                Regex regex = new Regex($"<{item.tag}>");
                fileStr = regex.Replace(fileStr, item.str);
            }
            return fileStr;
        }

        private void btnCreatFile_Click(object sender, EventArgs e)
        {
            ShablonInfo.Clear();
            ListData();
            ShablonInfo.Text = RplList();
        }
    }
}
