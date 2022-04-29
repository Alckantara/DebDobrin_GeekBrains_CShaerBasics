//Добрин Денис Кириллович
//3.
//    а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2 - y1, 2).
//        Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
//    б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

using System;

using Lesson1.DataClasses;
using ClassLibrary;
using ClassLibrary.Interfaces;


namespace Lesson1
{
    public class Task3 :ITask
    {
        public void Start()
        {
            Helper.PrintLine("Введите координаты точки А");
            Point A = new()
            {
                X = double.Parse(Helper.GetInputParameter("Ось абсцисс (x)")),
                Y = double.Parse(Helper.GetInputParameter("Ось ординат (y)"))
            };

            Helper.PrintLine("Введите координаты точки B");
            Point B = new()
            {
                X = double.Parse(Helper.GetInputParameter("Ось абсцисс (x)")),
                Y = double.Parse(Helper.GetInputParameter("Ось ординат (y)"))
            };

            Helper.PrintLine($"{GetDistanceBetweenPoints(A, B):F2}");
        }

        private double GetDistanceBetweenPoints(Point a, Point b) =>
            Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
    }
}
