using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.PeakFinder
{
    public class TwoDimensionsPeakFinder
    {
        public int Find(int[,] toFind)
        {
            var xLenght = toFind.GetLength(0);
            var yLenght = toFind.GetLength(1);

            var targetColumn = xLenght / 2;
            var peak = 0;

            while (true)
            {
                // find column bigger value
                var targetColumnMaxValueIndex = 0;
                var targetColumnMaxValue = 0;

                for (int i = 0; i < yLenght; i++)
                {
                    if (toFind[i, targetColumn] > targetColumnMaxValue)
                    {
                        targetColumnMaxValueIndex = i;
                        targetColumnMaxValue = toFind[i, targetColumn];
                    }
                }

                if (peak == targetColumnMaxValue)
                {
                    return peak;
                }

                // find the bigger value row peak
                var left = 0;
                var right = xLenght;

                while (true)
                {
                    var middle = (right + left) / 2;

                    var previewsPosition = middle - 1;
                    var nextPosition = middle + 1;

                    if (previewsPosition >= 0 &&
                        toFind[targetColumnMaxValueIndex, previewsPosition] > toFind[targetColumnMaxValueIndex, middle])
                    {
                        right = middle;
                        continue;
                    }

                    if (nextPosition < xLenght &&
                        toFind[targetColumnMaxValueIndex, nextPosition] > toFind[targetColumnMaxValueIndex, middle])
                    {
                        left = middle;
                        continue;
                    }

                    targetColumn = middle;
                    peak = toFind[targetColumnMaxValueIndex, middle];
                    break;
                }
            }
            
        }
    }
}
