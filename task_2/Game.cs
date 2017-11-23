using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Game
    {
        int maxCount;
        int guessNumber;
        int count = 0;
        private bool flag = true;
        public int Count { get => count; }
        string textResult = String.Empty;
        private int userNumber;
        public int UserNumber { set => userNumber = value; }
        public bool Flag { get => flag; }

        public Game()
        {
            MaxCount();
            GuessNumber();
        }

        /// <summary>
        /// Максимальное число попыток
        /// </summary>
        /// <returns></returns>
        void MaxCount()
        {
            maxCount = (int)Math.Log(100 - 1 + 1, 2) + 1;
        }

        /// <summary>
        /// Число которое нужно угадать
        /// </summary>
        /// <returns></returns>
        void GuessNumber()
        {
            Random rnd = new Random();

            guessNumber = rnd.Next(1, 100);
        }

        /// <summary>
        /// Проверка условий игры
        /// </summary>
        /// <returns></returns>
        string Result()
        {

            count++;
            if (userNumber == guessNumber)
            {
                flag = false;
                return $"Поздравляю! Вы угадали число за {count} попыток.";
            }
            else
            {
                if (userNumber > guessNumber)
                {
                    return $"Загаданое число меньше {userNumber}";
                }
                else
                {
                    return $"Загаданое число больше {userNumber}";
                }
            }
        }

        /// <summary>
        /// Сама игра
        /// </summary>
        /// <returns></returns>
        public string GuessGame()
        {
            if (count <= maxCount)
            {
                return Result();
            }
            else
            {
                flag = false;
                return $"Неудача. Вы не отгадали число {guessNumber} за {count}";
            }
        }

        /// <summary>
        /// Следующая игра
        /// </summary>
        public void NextGame()
        {
            GuessNumber();
            flag = true;
            count = 0;
        }
    }
}
