//Добрин Денис Кириллович
//1.Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
//    а) используя склеивание;
//    б) используя форматированный вывод;
//    в) используя вывод со знаком $.

using System;

using Lesson1.DataClasses;
using ClassLibrary;
using ClassLibrary.Interfaces;


namespace Lesson1
{
    public class Task1 :ITask
    {
        public void Start()
        {

            Helper.PrintLine("Введите свои данные:");

            Person someone = new() 
            {
                Name = Helper.GetInputParameter("Имя"),
                Surname = Helper.GetInputParameter("Фамилия"),
                Age = int.Parse(Helper.GetInputParameter("Возраст")),
                Height = double.Parse(Helper.GetInputParameter("Рост")),
                Weight = double.Parse(Helper.GetInputParameter("Вес")),
            };

            Helper.PrintLine($"Данные, полученные при помощи конкатенации:{ Environment.NewLine } { GetUserDataByConcat(someone) }{ Environment.NewLine }");
            Helper.PrintLine($"Данные, полученные при помощи форматного вывода:{ Environment.NewLine } { GetUserDataByFormat(someone) }{ Environment.NewLine }");
            Helper.PrintLine($"Данные, полученные при помощи интерполяции:{ Environment.NewLine } { GetUserDataByInterplation(someone) }");
        }

        private static string GetUserDataByConcat(Person person) =>
            person.Name + " " + person.Surname + " " + person.Age + " " + person.Height + " " + person.Weight;

        private static string GetUserDataByFormat(Person person) =>
            string.Format("{0} {1} {2} {3} {4}", person.Name, person.Surname, person.Age, person.Height, person.Weight);

        private static string GetUserDataByInterplation(Person person) =>
            $"{person.Name} {person.Surname} {person.Age} {person.Height} {person.Weight}";

    }
}
