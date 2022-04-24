//Добрин Денис Кириллович
//5.
//    а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//    б) Сделать задание, только вывод организовать в центре экрана.
//    в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y).

using System;

using Lesson1.DataClasses;

namespace Lesson1
{
    public class Task5 :ITask
    {
        public void Start()
        {
            Helper.PrintLine("Введите свои данные:");
            Person me = new()
            {
                Name = Helper.GetInputParameter("Имя"),
                Surname = Helper.GetInputParameter("Фамилия"),
                City = Helper.GetInputParameter("Город проживания")
            };

            string message = $"{ me.Name } { me.Surname }, город проживания - { me.City }";
            Helper.PrintLine(message, (Console.WindowWidth - message.Length) / 2, Console.WindowHeight / 2);
        }
    }
}
