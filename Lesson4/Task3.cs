//3.
//  а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
//     Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
//     метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
//  б)**Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
//  в) ***Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)


using System;
using System.Linq;
using System.Collections.Generic;

using ClassLibrary.Interfaces;
using ClassLibrary.Helpers;
using ClassLibrary;

namespace Lesson4
{
    public class Task3 : ITask
    {
        public void Start()
        {
            Helper.PrintLine("Пример массива №1");
            ArrayClass arrClass = new (new int[] { 1, -2, 3, 1, -5, 6 -4, 5, -6, 6, 6, -2, 3 });
            int[] arr = arrClass.GetArray();
            arr.Print();

            Helper.PrintLine("Инверсия массива №1");
            arr = arrClass.Inverse();
            arr.Print();

            Helper.PrintLine("Сумма элементов массива №1:");
            Helper.Print(arrClass.Sum);

            Helper.PrintLine("Количество максимальных элементов массива №1:");
            Helper.Print(arrClass.MaxCount);

            Helper.PrintLine("Умножение массива №1 на число 5:");
            arr = arrClass.Multy(5);
            arr.Print();


            Helper.PrintLine("Частота вхождения каждого элемента:");
            Dictionary<dynamic, int> dict = arrClass.CountEvetyNumberOccurrence();
            dict.Print();
        }
    }
}
