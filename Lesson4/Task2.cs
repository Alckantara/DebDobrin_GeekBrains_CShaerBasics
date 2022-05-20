//2.Реализуйте задачу 1 в виде статического класса StaticClass;
//  а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
//  б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
//  в)*Добавьте обработку ситуации отсутствия файла на диске.

using System;
using System.Linq;

using ClassLibrary.Helpers;
using ClassLibrary;


namespace Lesson4
{
    public static class Task2
    {
        public static void Start()
        {
            int arrLength = 20;
            int[] arr = new int[arrLength];
            int leftEdge = -10_000;
            int rightEdge = 10_000;

            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = new Random().Next(leftEdge, rightEdge + 1);
            }
            Helper.PrintLine("Исходный массив:");
            arr.Print();

            Helper.PrintLine();
            Helper.PrintLine();

            (int pairCount, int[,] pairs) = FindPairsWithOneDividableByThree(arr);
            int pairLongestElement = pairs.GetLongestElementLength();

            if (pairCount == 0)
                Helper.PrintLine("Не нашлось ни одной пары, удовлетворяющей условию");
            else
            {
                Helper.PrintLine($"Всего { pairCount } пар, удовлетворяющих условию:");
                for (int i = 0; i < pairCount; i++)
                {
                    Helper.Print($"{ i + 1 }) ");

                    for (int j = 0; j < 2; j++)
                    {
                        Helper.Print($"{ pairs[i, j].ToString().PadLeft(pairLongestElement, ' ') }");
                    }

                    Helper.PrintLine();
                }
            }
        }

        private static (int, int[,]) FindPairsWithOneDividableByThree(int[] arr)
        {
            int[,] result = new int[arr.Length, 2];
            int resultCaret = 0;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                bool currentEl = IsNumberDividableByAnother(arr[i], 3);
                bool nextEl = IsNumberDividableByAnother(arr[i + 1], 3);

                if ((currentEl && !nextEl) || (!currentEl && nextEl))
                {
                    result[resultCaret, 0] = arr[i];
                    result[resultCaret, 1] = arr[i + 1];

                    resultCaret++;
                }
            }

            return (resultCaret, result);
        }

        private static bool IsNumberDividableByAnother(int devisible, int devisor) =>
            devisible % devisor == 0;
    }
}
