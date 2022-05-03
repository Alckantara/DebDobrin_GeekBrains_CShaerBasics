using ClassLibrary;
using ClassLibrary.Interfaces;


namespace Lesson3
{
    public class Task2 : ITask
    {
        public void Start()
        {
            int[] values = new int[10];

            int counter = 0;
            while (true)
            {
                if (counter == 10)
                {
                    Helper.PrintLine($"Превышено максимальное число значений! Принудительное завершение...");
                    break;
                }

                bool isValueOk  = int.TryParse(Helper.GetInputParameter("Введите целое или число (для выхода введите 0)"), out int value);

                if (!isValueOk)
                {
                    Helper.PrintLine($"Вы ввели неверное значение. Попробуйте снова!");
                    continue;
                }

                if (value == 0)
                    break;

                if (!Helper.isEven(value) && Helper.isPositive(value))
                {
                    values[counter] = value;
                    counter++;
                }
            }

            Helper.PrintLine($"Вы ввели { counter } нечетных положительных чисел:");

            for (int i = 0; i < counter; i++)
            {
                Helper.Print($"{ values[i] }{ (((i + 1) != counter) ? ", " : "") }");
            }
        }
    }
}
