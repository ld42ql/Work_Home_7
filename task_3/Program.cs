﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_3
{
    #region
    /* Реализовать программу из предыдущего урока с шаблоном документа на отпуск в Windows Forms.
     * Сделать несколько текстовых полей(TextBox), куда человек вводит данные,
     * а по нажатии кнопки “Сделать” - видит готовое заявление на отпуск. */
    #endregion

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
