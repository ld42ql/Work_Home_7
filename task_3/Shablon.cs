using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Shablon
    {
        public string tag;
        public string str;

        /// <summary>
        /// Конструктор для заполнилнения массива
        /// </summary>
        /// <param name="tag">Поле изменения</param>
        /// <param name="newString">Данные</param>
        public Shablon(string tag, string newString)
        {
            this.tag = tag;
            str = newString;
        }

        /// <summary>
        /// Открываем шаблон
        /// </summary>
        /// <returns></returns>
       static public string OpenShablon()
        {
            try
            {
                return File.ReadAllText("shablon.txt");
            }
            catch (Exception e)
            {
                return $"{e}";
            }
        }
    }
}
