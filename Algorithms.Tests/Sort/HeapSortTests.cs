using Algorithms.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Algorithms.Tests.Sort
{
    [TestClass]
    public class HeapSortTests
    {
        [TestMethod]
        public void Sort1()
        {
            var toSort = new int[] { 1, 2, 3, 4, 5, 6 };
            ISort sort = new HeapSort();
            var sorted = sort.Sort(toSort);

            CollectionAssert.AreEqual(sorted, new int[] { 1, 2, 3, 4, 5, 6 });
        }

        [TestMethod]
        public void Sort2()
        {
            var toSort = new int[] { 6, 5, 4, 3, 2, 1 };

            ISort sort = new HeapSort();
            var sorted = sort.Sort(toSort);

            CollectionAssert.AreEqual(sorted, new int[] { 1, 2, 3, 4, 5, 6 });
        }

        [TestMethod]
        public void Sort3()
        {
            var toSort = new int[] { 2, 3, 6, 1, 5, 4 };

            ISort sort = new HeapSort();
            var sorted = sort.Sort(toSort);

            CollectionAssert.AreEqual(sorted, new int[] { 1, 2, 3, 4, 5, 6 });
        }

        [TestMethod]
        public void Sort4()
        {
            var toSort = new int[] { 2, 3, 6, 1, 5, 4, 7 };

            ISort sort = new HeapSort();
            var sorted = sort.Sort(toSort);

            CollectionAssert.AreEqual(sorted, new int[] { 1, 2, 3, 4, 5, 6, 7 });
        }
    }
}
