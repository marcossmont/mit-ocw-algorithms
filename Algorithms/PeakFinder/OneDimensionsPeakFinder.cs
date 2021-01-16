using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.PeakFinder
{
    public class OneDimensionsPeakFinder
    {
        public int Find(int[] toFind)
        {
            var left = 0;
            var right = toFind.Length;

            while (true)
            {
                var middle = (right + left) / 2;

                var previewsPosition = middle - 1;
                var nextPosition = middle + 1;

                if (previewsPosition >= 0 &&
                    toFind[previewsPosition] > toFind[middle])
                {
                    right = middle;
                    continue;
                }

                if (nextPosition < toFind.Length &&
                    toFind[nextPosition] > toFind[middle])
                {
                    left = middle;
                    continue;
                }

                return toFind[middle];
            }
        }
    }
}
