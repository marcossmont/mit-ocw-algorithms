using Algorithms.PriorityQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.PriorityQueue
{
    [TestClass]
    public class HeapPriorityQueueTests
    {
        [TestMethod]
        public void Test1()
        {
            HeapPriorityQueue priorityQueue = new HeapPriorityQueue();

            priorityQueue.Enqueue(1, () => { return "Item with priority 1"; });
            priorityQueue.Enqueue(2, () => { return "Item with priority 2"; });
            priorityQueue.Enqueue(3, () => { return "Item with priority 3"; });
            priorityQueue.Enqueue(4, () => { return "Item with priority 4"; });

            Assert.AreEqual(priorityQueue.Dequeue().Invoke(), "Item with priority 1");
            Assert.AreEqual(priorityQueue.Dequeue().Invoke(), "Item with priority 2");
            Assert.AreEqual(priorityQueue.Dequeue().Invoke(), "Item with priority 3");
            Assert.AreEqual(priorityQueue.Dequeue().Invoke(), "Item with priority 4");
        }

        [TestMethod]
        public void Test2()
        {
            HeapPriorityQueue priorityQueue = new HeapPriorityQueue();

            priorityQueue.Enqueue(4, () => { return "Item with priority 4"; });
            priorityQueue.Enqueue(3, () => { return "Item with priority 3"; });
            priorityQueue.Enqueue(2, () => { return "Item with priority 2"; });
            priorityQueue.Enqueue(1, () => { return "Item with priority 1"; });

            Assert.AreEqual(priorityQueue.Dequeue().Invoke(), "Item with priority 1");
            Assert.AreEqual(priorityQueue.Dequeue().Invoke(), "Item with priority 2");
            Assert.AreEqual(priorityQueue.Dequeue().Invoke(), "Item with priority 3");
            Assert.AreEqual(priorityQueue.Dequeue().Invoke(), "Item with priority 4");
        }

        [TestMethod]
        public void Test3()
        {
            HeapPriorityQueue priorityQueue = new HeapPriorityQueue();

            priorityQueue.Enqueue(2, () => { return "Item with priority 2"; });
            priorityQueue.Enqueue(4, () => { return "Item with priority 4"; });
            priorityQueue.Enqueue(3, () => { return "Item with priority 3"; });
            priorityQueue.Enqueue(1, () => { return "Item with priority 1"; });

            Assert.AreEqual(priorityQueue.Dequeue().Invoke(), "Item with priority 1");
            Assert.AreEqual(priorityQueue.Dequeue().Invoke(), "Item with priority 2");
            Assert.AreEqual(priorityQueue.Dequeue().Invoke(), "Item with priority 3");
            Assert.AreEqual(priorityQueue.Dequeue().Invoke(), "Item with priority 4");
        }
    }
}
