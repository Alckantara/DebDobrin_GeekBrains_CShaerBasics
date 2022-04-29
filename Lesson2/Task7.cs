//Добрин Денис Кириллович
//7.
//    a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

using System;
using System.Linq;

using ClassLibrary;
using ClassLibrary.Interfaces;


namespace Lesson2
{
    public class Task7 : ITask
    {
        public void Start()
        {
            Helper.PrintLine("Введите грацицы (два целых числа):");
            int value1 = int.Parse(Helper.GetInputParameter("Число №1"));
            int value2 = int.Parse(Helper.GetInputParameter("Число №2"));

            if (value1 >= value2)
                throw new Exception("Число №1 должно быть меньше числа №2");

            Helper.Print($"Числа, входящие в диапазон ({ value1 }, { value2 }):");
            PrintValuesInRange(value1, value2);

            Helper.PrintLine();
            Helper.PrintLine($"Сумма чисел в диапазоне ({ value1 }, { value2 }) = { PrintValuesSumInRange(value1, value2) }");
        }

        private void PrintValuesInRange(int a, int b)
        {
            if (a > b)
                return;

            Helper.Print(a + " ");
            PrintValuesInRange(++a, b);
        }
        
        private int PrintValuesSumInRange(int a, int b)
        {
            if (a == b)
                return b;

            return a + PrintValuesSumInRange(++a, b);
        }
    }
}
