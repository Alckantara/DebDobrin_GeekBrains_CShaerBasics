//Добрин Денис Кириллович
//Выбор задания

using System;

using Lesson1;

namespace DebDobrin_GeekBrains_CShaerBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Helper.PrintLine($"Выберите задание (для выхода нажмите 'Esc'):{ Environment.NewLine }" +
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
                            new Task1().Start();
                            break;
                        case ConsoleKey.D2:
                            new Task2().Start();
                            break;
                        case ConsoleKey.D3:
                            new Task3().Start();
                            break;
                        case ConsoleKey.D4:
                            new Task4().Start();
                            break;
                        case ConsoleKey.D5:
                            new Task5().Start();
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
