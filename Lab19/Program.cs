using Generics;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab19
{
    public delegate T[] SumTwoArrays<T>(T[] array1, T[] array2);

    class Program
    {
        static void Main(string[] args)
        {
            #region Assignment 1
            //IEnumerable oddNumbers = new OddNumbersEnumerable(IntMaxValue(20));

            //foreach (int i in oddNumbers)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Assignment 2
            ArrayHelper<int> arrayHelper = new ArrayHelper<int>();

            int[] firstArray = new int[] { 1, 2, 3, 4, 5 };
            int[] secondArray = new int[] { 5, 4, 3, 2, 1 };

            SumTwoArrays<int> SumTwoArr = arrayHelper.SumOfTwoArrays;

            int[] result = SumTwoArr(firstArray, secondArray);

            foreach(int i in result)
            {
                Console.WriteLine(i);
            }

            //Func<int> SearchForElemAndIndex = arrayHelper.ReturnElementAndIndex<int>;

            #endregion
        }

        #region Assignment 1
        public static IEnumerable<int> IntMaxValue(int n = Int32.MaxValue)
        {
            for (int i = 0; i <= n; i++)
            {
                yield return i;

                if (i.Equals(n))
                    yield break;
            }
        }
        #endregion
    }

    #region Assignment 1
    public class OddNumbersEnumerable : IEnumerable<int>
    {
        private IEnumerable<int> numbers;

        public OddNumbersEnumerable(IEnumerable<int> elements)
        {
            numbers = elements;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return OddNumbersGetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return OddNumbersGetEnumerator();
        }

        private IEnumerator<int> OddNumbersGetEnumerator()
        {
            foreach (int i in numbers)
            {
                if (i % 2 != 0)
                {
                    yield return i;
                }
            }
        }
    }
    #endregion
}
