using System;

namespace Algorithms.Sort
{
    public class InsertionSort : ISort
    {
        public int[] Sort(int[] toSort)
        {
            for (int j = 1; j < toSort.Length; j++)
            {
                var key = toSort[j];
                var i = j - 1;

                while (i >= 0 && toSort[i] > key)
                {
                    toSort[i + 1] = toSort[i];
                    i = i - 1;
                }

                toSort[i + 1] = key;
            }

            return toSort;
        }
    }
}
