//Добрин Денис Кириллович
//4.Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
//    а) с использованием третьей переменной;
//    б) *без использования третьей переменной.

using ClassLibrary;
using ClassLibrary.Interfaces;


namespace Lesson1
{
    public class Task4 :ITask
    {
        public void Start()
        {
            Helper.PrintLine("Введите два числа типа integer:");
            int fstValue = int.Parse(Helper.GetInputParameter("a", "="));
            int scndValue = int.Parse(Helper.GetInputParameter("b", "="));

            SwapIntegersWithBuffVariable(ref fstValue, ref scndValue);
            Helper.PrintLine($"Обмен значений, с использованием буфферной переменной: a = { fstValue }, b = { scndValue }");

            SwapIntegersWithoutBuffVariable(ref fstValue, ref scndValue);
            Helper.PrintLine($"Обмен значений, без использованием буфферной переменной: a = { fstValue }, b = { scndValue }");
        }

        private void SwapIntegersWithBuffVariable(ref int a, ref int b)
        {
            int buff = a;
            a = b;
            b = buff;
        }
        
        private void SwapIntegersWithoutBuffVariable(ref int a, ref int b)
        {
            a = b - a;
            b = b - a;
            a = b + a;
        }
    }
}
