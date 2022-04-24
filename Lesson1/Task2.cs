//Добрин Денис Кириллович
//2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

using System;
using Lesson1.DataClasses;

namespace Lesson1
{
    public class Task2 :ITask
    {
        public void Start()
        {
            Person someone = new()
            {
                Height = double.Parse(Helper.GetInputParameter("Рост")),
                Weight = double.Parse(Helper.GetInputParameter("Вес"))
            };

            Helper.PrintLine($"Индекс массы тела равен { GetPersonBmi(someone) }");
        }

        /// <summary>
        /// Рассчет индекста массы тела
        /// </summary>
        /// <returns>Интекс массы тела</returns>
        /// <param name="height">Рост</param>
        /// <param name="weight">Вес</param>
        public double GetPersonBmi(Person person) =>
            person.Weight / (person.Height * person.Height);
    }
}
