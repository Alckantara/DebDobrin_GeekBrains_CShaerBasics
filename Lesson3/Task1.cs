using ClassLibrary;
using ClassLibrary.DataClasses;
using ClassLibrary.Interfaces;

namespace Lesson3
{
    public class Task1 :ITask
    {
        public void Start()
        {
            Helper.PrintLine("Введите первое комплексное число A:");

            bool isRealUnitOk = int.TryParse(Helper.GetInputParameter("Действительная часть:", ""), out int realUnit);
            bool isImaginaryUnitOk = int.TryParse(Helper.GetInputParameter("Мнимая часть:", ""), out int imaginaryUnit);
            Complex complex1 = new Complex(realUnit, imaginaryUnit);

            Helper.PrintLine("Введите второе комплексное число B:");

            isRealUnitOk = int.TryParse(Helper.GetInputParameter("Действительная часть:", ""), out realUnit);
            isImaginaryUnitOk = int.TryParse(Helper.GetInputParameter("Мнимая часть:", ""), out imaginaryUnit);
            Complex complex2 = new Complex(realUnit, imaginaryUnit);

            Helper.PrintLine($"A = { complex1 }");
            Helper.PrintLine($"B = { complex2 }");

            Helper.PrintLine($"Выберите операцию над комплексными числами (для выхода нажмите 'Esc'):{ Environment.NewLine }" +
                    $"+: A + B{ Environment.NewLine }" +
                    $"-: A - B{ Environment.NewLine }" +
                    $"*: A * B{ Environment.NewLine }" +
                    $"/: A / B{ Environment.NewLine }");

            while (true)
            {
                ConsoleKeyInfo input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Escape)
                    break;
                
                switch (input.Key)
                {
                    case ConsoleKey.OemMinus:
                    case ConsoleKey.Add:
                        Helper.PrintLine($"A + B = { complex1 + complex2 }");
                        break;
                    case ConsoleKey.OemPlus:
                    case ConsoleKey.Subtract:
                        Helper.PrintLine($"A - B = { complex1 - complex2 }");
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.Multiply:
                        Helper.PrintLine($"A * B = { complex1 - complex2 }");
                        break;
                    case ConsoleKey.Oem8:
                    case ConsoleKey.Divide:
                        Helper.PrintLine($"A / B = { complex1 - complex2 }");
                        break;
                    default:
                        Helper.PrintLine("");
                        break;
                }
            }
        }
    }
}