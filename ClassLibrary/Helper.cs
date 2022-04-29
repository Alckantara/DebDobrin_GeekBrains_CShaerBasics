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

        public static void Print(string message, int x = -1, int y = -1)
        {
            if (x != -1 && y != -1)
                SetCursorPosition(x, y);

            Console.Write(message);
        }

        public static void SetCursorPosition(int x, int y)
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
        }
    }
}
