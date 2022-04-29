//Добрин Денис Кириллович
//2.Написать метод подсчета количества цифр числа.

using System;

using ClassLibrary;
using ClassLibrary.Interfaces;

namespace Lesson2
{
    public class Task2 :ITask
    {
        public void Start()
        {
            double value = double.Parse(Helper.GetInputParameter("Введите целое или дробное число"));

            Helper.PrintLine($"Количество цифр в вашем числе = { GetNumberOfDigits(value) }");
        }

        private int GetNumberOfDigits(double value)
        {
            return value.ToString().Replace(".", "").Length;
        }
    }
}
