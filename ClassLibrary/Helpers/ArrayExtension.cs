using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Helpers
{
    public static class ArrayExtension
    {
        public static int GetLongestElementLength<T>(this IEnumerable<T> arr) => 
            arr.Select(x => x.ToString().Length).OrderByDescending(x => x).First();

        public static int GetLongestElementLength<T>(this T[,] arr)
        {
            int result = arr[0, 0].ToString().Length;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (result < arr[i, j].ToString().Length)
                        result = arr[i, j].ToString().Length;
                }
            }

            return result;
        }

        public static void Print<T>(this IEnumerable<T> arr, string separator = " ")
        {
            Helper.PrintLine();
            int longestEl = GetLongestElementLength(arr);

            foreach (T item in arr)
            {
                Helper.Print($"{ item.ToString().PadLeft(longestEl, ' ') }{ separator }");
            }
        }

        public static void Print<T>(this Dictionary<T, int> arr, string separator = " ")
        {
            Helper.PrintLine();
            int longestEl = GetLongestElementLength(arr.Select(x => x.Key));
            int longestCounts = GetLongestElementLength(arr.Select(x => x.Value));

            foreach (KeyValuePair<T, int> item in arr)
            {
                Helper.PrintLine($"{ item.Key.ToString().PadLeft(longestEl, ' ') }{ separator }{ item.Value.ToString().PadLeft(longestCounts, ' ') }");
            }
        }

        public static void Print<T>(this IEnumerable<IEnumerable<T>> arr, string columSeparator = " ", string rowSeparator = "\n")
        {
            Helper.PrintLine();
            int longestEl = GetLongestElementLength(arr);

            foreach (IEnumerable<T> item in arr)
            {
                foreach (IEnumerable<T> item2 in item)
                {
                    Helper.Print($"{ item.ToString().PadLeft(longestEl, ' ') }{ columSeparator }");
                }
                Helper.Print(rowSeparator);
            }
        }

        public static void Print<T>(this T[,] arr, string columSeparator = " ", string rowSeparator = "\n")
        {
            Helper.PrintLine();
            int longestEl = GetLongestElementLength(arr);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Helper.Print($"{ arr[i, j].ToString().PadLeft(longestEl, ' ') }{ columSeparator }");
                }
                Helper.Print(rowSeparator);
            }
        }

        public static T[] FullCopy<T>(this T[] arr)
        {
            T[] result = new T[arr.Length];

            for(int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i];
            }

            return result;
        }
    }
}
