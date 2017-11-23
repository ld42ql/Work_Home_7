using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    #region *** Описание***
    /* Существует алгоритмическая игра “Удвоитель”. В этой игре человеку предлагается какое-то число, а человек должен, управляя роботом “Удвоитель”, 
     * достичь этого числа за минимальное число шагов. Робот умеет выполнять несколько команд: увеличить число на 1, умножить число на 2 и сбросить число до 1. 
     * Начальное значение удвоителя равно 1.
     * Реализовать класс “Удвоитель”. Класс хранит в себе поле current - текущее значение, finish - число, которого нужно достичь, 
     * конструктор, в котором задается конечное число. 
     * Методы: увеличить число на 1, увеличить число в два раза, сброс текущего до 1, свойство Current, которое возвращает текущее значение,
     * свойство Finish,которое возвращает конечное значение.
     * Создать с помощью этого класса игру, в которой компьютер загадывает число, а человек. выбирая из меню на экране, отдает команды удвоителю
     * и старается получить это число за наименьшее число ходов. 
     * Если человек получает число больше положенного, игра прекращается.*/
    #endregion
    class Game
    {
        static public int lvl = 0;

        static int minNumber = 10;
        static int maxNumber = 40;

        
        static Doubler NewGame;
        
        /// <summary>
        /// Запуск игры и увлечение сложности
        /// </summary>
        static public void StartGame()
        {
            NewGame = new Doubler(minNumber, maxNumber);
            minNumber = FinishGame;
            maxNumber += 25;
            Doubler.ResetValue();
            lvl++;
        }

        static public int FinishGame { get => NewGame.Finish; }
        static public int Current { get => Doubler.Current; }
        
        /// <summary>
        /// Операции в игре
        /// </summary>
        /// <param name="comand">операция</param>
        static public void OperationGame(ComandGame comand)
        {
            comand();
        }

        /// <summary>
        /// Ввывод результата
        /// </summary>
        /// <returns></returns>
        static public string Result()
        {
            return Doubler.Current == NewGame.Finish ? $"Поздравляю!!!\nВы достигли числа {NewGame.Finish} за " +
                $"{Doubler.Count} шагов." : $"Вы проиграли :(\nПревысили число {NewGame.Finish} на " +
                $"{Doubler.Current - NewGame.Finish} за {Doubler.Count} шагов";
        }

    }
}
