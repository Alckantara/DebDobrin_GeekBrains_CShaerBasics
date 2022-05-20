using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Helpers
{
    public class ArrayClass
    {
        private int arrayLength = 0;
        private dynamic _array = null;
        private dynamic _buffArray;

        public dynamic Sum
        {
            get
            {
                dynamic result = 0;
                foreach (dynamic item in _array)
                {
                    result += item;
                }

                return result;
            }
        }

        public int MaxCount
        {
            get
            {
                dynamic max = _array[0];
                int count = 1;
                foreach (dynamic item in _array)
                {
                    if (item > max)
                    {
                        max = item;
                        count = 1;
                    }
                    count++;
                }

                return count;
            }
        }


        public ArrayClass(int[] arr)
        {
            _array = arr.FullCopy();
            _buffArray = arr.FullCopy();
            arrayLength = arr.Length;
        }

        public ArrayClass(double[] arr)
        {
            _array = arr.FullCopy();
            _buffArray = arr.FullCopy();
            arrayLength = arr.Length;
        }

        public Dictionary<dynamic, int> CountEvetyNumberOccurrence()
        {
            List<dynamic> result = new List<dynamic>();

            foreach (dynamic item in _array)
            {
                result.Add(item);
            }

            return result.GroupBy(x => x).ToDictionary(x => x.Key, y => y.Count());
        }

        public dynamic GetArray() =>
            _array;

        public dynamic Inverse()
        {
            for (int i = 0; i < arrayLength; i++)
            {
                _buffArray[i] = -_array[i];
            }

            return _buffArray;
        }

        //public dynamic Multy(int multiplier)
        //{
        //    for (int i = 0; i < arrayLength; i++)
        //    {
        //        _buffArray[i] = _array[i] * multiplier;
        //    }

        //    return _buffArray;
        //}

        public dynamic Multy(double multiplier)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                _buffArray[i] = _array[i] * multiplier;
            }

            return _buffArray;
        }
    }
}
