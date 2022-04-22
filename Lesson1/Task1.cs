using System;
using System.Collections.Generic;
using Lesson1.DataClasses.Task1;

namespace Lesson1
{
    public static class Task1
    {
        public static void Start()
        {

            Console.WriteLine("Введите свои данные:");

            Person someone = new() 
            {
                Name = GetUserParameter("Имя"),
                Surname = GetUserParameter("Фамилия"),
                Age = GetUserParameter("Возраст"),
                Height = GetUserParameter("Рост"),
                Weight = GetUserParameter("Вес"),
            };

            Console.WriteLine($"Данные, полученные при помощи конкатенации:{ Environment.NewLine } { GetUserDataByConcat(someone) }{ Environment.NewLine }");
            Console.WriteLine($"Данные, полученные при помощи форматного вывода:{ Environment.NewLine } { GetUserDataByFormat(someone) }{ Environment.NewLine }");
            Console.WriteLine($"Данные, полученные при помощи интерполяции:{ Environment.NewLine } { GetUserDataByInterplation(someone) }");
        }

        private static string GetUserDataByConcat(Person person) 
            => person.Name + " " + person.Surname + " " + person.Age + " " + person.Height + " " + person.Weight;

        private static string GetUserDataByFormat(Person person)
            => string.Format("{0} {1} {2} {3} {4}", person.Name, person.Surname, person.Age, person.Height, person.Weight);

        private static string GetUserDataByInterplation(Person person)
            => $"{person.Name} {person.Surname} {person.Age} {person.Height} {person.Weight}";

        private static string GetUserParameter(string question)
        {
            Console.Write($"{question} - ");
            return Console.ReadLine();
        }
    }
}
