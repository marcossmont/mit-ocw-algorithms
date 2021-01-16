using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sort
{
    public class MergeSort : ISort
    {
        public int[] Sort(int[] toSort)
        {
            var middle = toSort.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[toSort.Length - middle];

            for (int i = 0; i < middle; i++)
            {
                left[i] = toSort[i];
            }

            for (int i = middle; i < toSort.Length; i++)
            {
                right[i - middle] = toSort[i];
            }

            if (left.Length > 1)
            {
                left = Sort(left);
            }

            if (right.Length > 1)
            {
                right = Sort(right);
            }

            int[] result = new int[toSort.Length];

            int leftIndex = 0;
            int rightIndex = 0;
            int resultIndex = 0;

            while (resultIndex < result.Length)
            {
                if (left.Length > leftIndex && right.Length > rightIndex)
                {
                    if (left[leftIndex] < right[rightIndex])
                    {
                        result[resultIndex] = left[leftIndex];
                        leftIndex++;
                    }
                    else
                    {
                        result[resultIndex] = right[rightIndex];
                        rightIndex++;
                    }
                }
                else if (left.Length > leftIndex)
                {
                    result[resultIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    result[resultIndex] = right[rightIndex];
                    rightIndex++;
                }

                resultIndex = leftIndex + rightIndex;
            }

            return result;
        }
    }
}
