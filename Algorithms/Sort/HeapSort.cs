using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sort
{
    public class HeapSort : ISort
    {
        public int[] Sort(int[] toSortArray)
        {
            var heap = BuildMaxHeap(toSortArray);           
         
            var sortedArray = new int[toSortArray.Length];

            while (heap.Size > 2)
            {
                var heapLastIndex = heap.Size - 1;
                SwapValues(heap.Array, 0, heapLastIndex);
                sortedArray[heapLastIndex] = heap.Array[heapLastIndex];
                heap.Size--;
                MaxHeapfy(heap, 0);
            }

            sortedArray[1] = heap.Array[0];
            sortedArray[0] = heap.Array[1];

            return sortedArray;
        }

        private Heap BuildMaxHeap(int[] array)
        {
            var heap = new Heap(array);
            
            var startBuildHeapIndex = (array.Length / 2) - 1;
            for (int index = startBuildHeapIndex; index >= 0; index--)
            {
                MaxHeapfy(heap, index);
            }

            return heap;
        }

        private void MaxHeapfy(Heap heap, int index)
        {
            var leftIndex = (index * 2) + 1;
            var rightIndex = (index * 2) + 2;

            int largestIndex = index;

            if (leftIndex < heap.Size && heap.Array[leftIndex] > heap.Array[index])
            {
                largestIndex = leftIndex;
            }
            if (rightIndex < heap.Size && heap.Array[rightIndex] > heap.Array[largestIndex])
            {
                largestIndex = rightIndex;
            }

            if (largestIndex != index)
            {
                SwapValues(heap.Array, index, largestIndex);
                MaxHeapfy(heap, largestIndex);
            }
        }

        private void SwapValues(int[] array, int firstIndex, int secondIndex)
        {
            var largestValue = array[secondIndex];
            array[secondIndex] = array[firstIndex];
            array[firstIndex] = largestValue;
        }

        private class Heap
        {
            public int[] Array { get; set; }
            public int Size { get; set; }

            public Heap(int[] array)
            {
                Array = array;
                Size = array.Length;
            }
        }
    }
}
