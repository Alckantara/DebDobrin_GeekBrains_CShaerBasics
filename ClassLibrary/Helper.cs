using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Helper
    {
        public static string GetInputParameter(string question = "", string separator = "-")
        {
            if (question != string.Empty)
                Helper.Print($"{question} {separator} ");
            return Console.ReadLine();
        }

        public static void PrintLine(string message = "", int x = -1, int y = -1)
        {
            if (x != -1 && y != -1)
                SetCursorPosition(x, y);

            Console.WriteLine(message);
        }

        public static void PrintLine<T>(T message, int x = -1, int y = -1)
        {
            PrintLine(message, x, y);
        }

        public static void Print<T>(T message, int x = -1, int y = -1)
        {
            if (x != -1 && y != -1)
                SetCursorPosition(x, y);

            Console.Write(message.ToString());
        }

        public static void SetCursorPosition(int x, int y)
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
        }

        public static bool isEven(int value) =>
            value % 2 == 0;

        public static bool isPositive(int value) =>
            value > 0;
    }
}
