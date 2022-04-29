//Добрин Денис Кириллович
//3.С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

using System;

using ClassLibrary;
using ClassLibrary.Interfaces;

namespace Lesson2
{
    public class Task3 : ITask
    {
        public void Start()
        {
            int counter = 0;
            while (true)
            {
                int value = int.Parse(Helper.GetInputParameter("Введите целое или число (для выхода введите 0)"));

                if (value == 0)
                    break;

                if (!isEven(value) && isPositive(value))
                    counter++;
            }
            
            Helper.PrintLine($"Вы ввели { counter } нечетных положительных чисел");
        }

        private bool isEven(int value) =>
            value % 2 == 0;

        private bool isPositive(int value) =>
            value > 0;
    }
}
