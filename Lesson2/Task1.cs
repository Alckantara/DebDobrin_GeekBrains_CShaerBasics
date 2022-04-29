//Добрин Денис Кириллович
//1. Написать метод, возвращающий минимальное из трёх чисел.

using System;
using System.Linq;

using ClassLibrary;
using ClassLibrary.Interfaces;


namespace Lesson2
{
    public class Task1 :ITask
    {
        public void Start()
        {
            Helper.PrintLine("Введите 3 числа для сравнения:");
            double value1 = double.Parse(Helper.GetInputParameter("Число №1"));
            double value2 = double.Parse(Helper.GetInputParameter("Число №2"));
            double value3 = double.Parse(Helper.GetInputParameter("Число №3"));

            Helper.PrintLine($"Минимальное из всех чисел: { GetMinValue(value1, value2, value3) }");
        }

        private double GetMinValue(params double[] values)
        {
            if (values.ToList().Count == 0)
                throw new Exception("Список не должен быть пуст!");

            double minValue = values[0];

            foreach(double value in values)
            {
                if (value < minValue)
                    minValue = value;
            }

            return minValue;
        }
    }
}
