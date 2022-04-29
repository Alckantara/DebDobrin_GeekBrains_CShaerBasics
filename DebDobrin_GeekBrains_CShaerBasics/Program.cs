﻿//Добрин Денис Кириллович
//Выбор задания

using System;
using System.Threading;

using ClassLibrary;

namespace DebDobrin_GeekBrains_CShaerBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper.PrintLine("На данном этапе программы не реализована защита от неверных данных. Пожалуйста, будте осторожны!");
            Thread.Sleep(3_000);

            //TODO: Добавить нормальный выбор задания (вынести в методы, разработать шаблон для разных уроков)
            while (true)
            {
                Console.Clear();

                Helper.PrintLine($"Выберите номер урока (для выхода нажмите 'Esc'):{ Environment.NewLine }" +
                    $"1 - Урок 1. Введение. Базовые типы данных. Консоль. Классы и методы.{ Environment.NewLine }" +
                    $"2 - Урок 2. Управляющие конструкции{ Environment.NewLine }");

                ConsoleKeyInfo input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Escape)
                    break;

                try
                {
                    switch (input.Key)
                    {
                        case ConsoleKey.D1:
                            StartLesson1();
                            break;
                        case ConsoleKey.D2:
                            StartLesson2();
                            break;
                        default:
                            Helper.PrintLine("Введено неверное значение. Попробуйте снова!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Helper.PrintLine("Вы ввели не числовое значение. Попробуйте снова");
                }

                Helper.PrintLine($"{ Environment.NewLine }{ Environment.NewLine } Нажмите любую кнопку, чтобы продолжить..");
                Console.ReadKey();
            }
        }


        public static void StartLesson1()
        {
            while (true)
            {
                Console.Clear();

                Helper.PrintLine($"Выберите задание урока №1 (для выхода нажмите 'Esc'):{ Environment.NewLine }" +
                    $"1 - Программа «Анкета»{ Environment.NewLine }" +
                    $"2 - Рассчет индекса массы тела{ Environment.NewLine }" +
                    $"3 - Расстояние между точками{ Environment.NewLine }" +
                    $"4 - Обмен значений переменных{ Environment.NewLine }" +
                    $"5 - Вывгод данных в центре экрана{ Environment.NewLine }");

                ConsoleKeyInfo input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Escape)
                    break;

                try
                {
                    switch (input.Key)
                    {
                        case ConsoleKey.D1:
                            new Lesson1.Task1().Start();
                            break;
                        case ConsoleKey.D2:
                            new Lesson1.Task2().Start();
                            break;
                        case ConsoleKey.D3:
                            new Lesson1.Task3().Start();
                            break;
                        case ConsoleKey.D4:
                            new Lesson1.Task4().Start();
                            break;
                        case ConsoleKey.D5:
                            new Lesson1.Task5().Start();
                            break;
                        default:
                            Helper.PrintLine("Введено неверное значение. Попробуйте снова!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Helper.PrintLine("Вы ввели неверное числовое значение. Попробуйте снова");
                }

                Helper.PrintLine($"{ Environment.NewLine }{ Environment.NewLine } Нажмите любую кнопку, чтобы продолжить..");
                Console.ReadKey();
            }
        }


        public static void StartLesson2()
        {
            while (true)
            {
                Console.Clear();

                Helper.PrintLine($"Выберите задание урока №2 (для выхода нажмите 'Esc'):{ Environment.NewLine }" +
                    $"1 - Минимальное из трёх чисел{ Environment.NewLine }" +
                    $"2 - Подсчет колличества цифр числа{ Environment.NewLine }" +
                    $"3 - Сумма нечетных положительных чисел{ Environment.NewLine }" +
                    $"7 - Рекурсивные методы{ Environment.NewLine }");

                ConsoleKeyInfo input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Escape)
                    break;

                try
                {
                    switch (input.Key)
                    {
                        case ConsoleKey.D1:
                            new Lesson2.Task1().Start();
                            break;
                        case ConsoleKey.D2:
                            new Lesson2.Task2().Start();
                            break;
                        case ConsoleKey.D3:
                            new Lesson2.Task3().Start();
                            break;
                        case ConsoleKey.D7:
                            new Lesson2.Task7().Start();
                            break;
                        default:
                            Helper.PrintLine("Введено неверное значение. Попробуйте снова!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Helper.PrintLine("Вы ввели неверное числовое значение. Попробуйте снова");
                }

                Helper.PrintLine($"{ Environment.NewLine }{ Environment.NewLine } Нажмите любую кнопку, чтобы продолжить..");
                Console.ReadKey();
            }
        }
    }
}
