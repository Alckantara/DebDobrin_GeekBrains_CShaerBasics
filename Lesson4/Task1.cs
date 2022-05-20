//1.Дан целочисленный массив из 20 элементов.
//Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
//Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
//В данной задаче под парой подразумевается два подряд идущих элемента массива.

using System;
using System.Linq;

using ClassLibrary.Interfaces;
using ClassLibrary.Helpers;
using ClassLibrary;

namespace Lesson4
{
    public class Task1 : ITask
    {
        public void Start()
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

        private (int, int[,]) FindPairsWithOneDividableByThree(int[] arr)
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

        private bool IsNumberDividableByAnother(int devisible, int devisor) =>
            devisible % devisor == 0;
    }
}
