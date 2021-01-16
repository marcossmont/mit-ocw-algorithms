using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.PriorityQueue
{
    public class HeapPriorityQueue : IPriorityQueue
    {
        private Heap heap;

        public HeapPriorityQueue()
        {
            heap = new Heap();
        }

        // heap-minimun
        public Func<string> Peek()
        {
            if (heap.Size == 0)
            {
                throw new QueueUnderflowException();
            }

            return heap.Array[0].Action;
        }

        // heap-extract-minimun
        public Func<string> Dequeue()
        {
            if (heap.Size == 0)
            {
                throw new QueueUnderflowException();
            }
            
            heap.Size--;

            var prioritaryTask = heap.Array[0];
            heap.Array[0] = heap.Array[heap.Size];
            heap.Array[heap.Size] = prioritaryTask;

            MinHeapfy(heap, 0);

            return prioritaryTask.Action;
        }

        // min-heap-insert
        public void Enqueue(int priority, Func<string> action)
        {
            if (heap.Size == heap.Array.Length)
            {
                throw new QueueOverflowException();
            }

            heap.Array[heap.Size] = new Task(int.MaxValue, action);
            DecreasePriority(heap.Size, priority);
            heap.Size++;
        }

        // heap-increase-key
        private void DecreasePriority(int index, int newPriority)
        {
            if (newPriority > heap.Array[index].Priority)
            {
                new InvalidOperationException();
            }

            heap.Array[index].Priority = newPriority;

            var parentIndex = index / 2;
            while (index > 0 && heap.Array[parentIndex].Priority > heap.Array[index].Priority)
            {
                SwapValues(heap.Array, parentIndex, index);
                index = parentIndex;
                parentIndex = index / 2;
            }
        }

        private class Heap
        {
            public Task[] Array { get; set; }
            public int Size { get; set; }

            public Heap()
            {
                Array = new Task[20];
                Size = 0;
            }
        }

        private void MinHeapfy(Heap heap, int index)
        {
            var leftIndex = (index * 2) + 1;
            var rightIndex = (index * 2) + 2;

            int largestIndex = index;

            if (leftIndex < heap.Size && heap.Array[leftIndex].Priority < heap.Array[index].Priority)
            {
                largestIndex = leftIndex;
            }
            if (rightIndex < heap.Size && heap.Array[rightIndex].Priority < heap.Array[largestIndex].Priority)
            {
                largestIndex = rightIndex;
            }

            if (largestIndex != index)
            {
                SwapValues(heap.Array, index, largestIndex);
                MinHeapfy(heap, largestIndex);
            }
        }

        private void SwapValues(Task[] array, int firstIndex, int secondIndex)
        {
            var largestValue = array[secondIndex];
            array[secondIndex] = array[firstIndex];
            array[firstIndex] = largestValue;
        }

        private class Task
        {
            public Task(int priority, Func<string> action)
            {
                Priority = priority;
                Action = action;
            }

            public int Priority { get; set; }
            public Func<string> Action { get; set; }
        }
    }
}
