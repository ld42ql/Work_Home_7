using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    delegate void ComandGame();

    class Doubler
    {
        /// <summary>
        /// Текущие число
        /// </summary>
        static public int Current { get => current; }
        static int current = 0;

        static private int count;
        static public int Count { get => count; }

        static List<int> listCurrent;

        /// <summary>
        /// Конечное число
        /// </summary>
        public int Finish { get => finish; }
        int finish;

        /// <summary>
        /// Результат в виде строки
        /// </summary>
        public string StringResult { get => stringResult; set => stringResult = value; }
        private string stringResult;

        /// <summary>
        /// Конструктор, в котором задается конечное число.
        /// </summary>
        /// <param name="min">Генерация от</param>
        /// <param name="max">Генерация до</param>
        public Doubler(int min, int max)
        {
            Random rnd = new Random();
            this.finish = rnd.Next(min, max);
           
            count = 0;
            listCurrent = new List<int>(finish + 100);
        }

        /// <summary>
        /// увеличить число на 1
        /// </summary>
        static public void IncreaseValue()
        {
            //current = listCurrent[count - 1];
            current++;
            Value();
        }

        /// <summary>
        /// увеличить число в два раза
        /// </summary>
        static public void MultValue()
        {
            //current = listCurrent[count - 1];
            current *= 2;
            Value();
        }

        /// <summary>
        /// сброс текущего до 1
        /// </summary>
        static public void ResetValue()
        {
            current = 1;
            Value(); 
        }

        /// <summary>
        /// Вернуться на ход назад
        /// </summary>
        static public void ReturnValue()
        {
            if (count > 1)
            {
                count--;
            }
            current = listCurrent[count - 1];
        }

        static void Value()
        {
            count++;
            listCurrent.Insert(count - 1, current);
        }
    }
}
