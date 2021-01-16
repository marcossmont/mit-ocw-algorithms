using Algorithms.PeakFinder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sort
{
    [TestClass]
    public class OneDimensionsPeakFinderTests
    {
        [TestMethod]
        public void Find1()
        {
            var toFind = new int[] { 8, 9, 10, 2, 5, 6 };

            var peakFinder = new OneDimensionsPeakFinder();
            var peak = peakFinder.Find(toFind);

            Assert.AreEqual(10, peak);
        }

        [TestMethod]
        public void Find2()
        {
            var toFind = new int[] { 8, 9, 10, 12, 15 };

            var peakFinder = new OneDimensionsPeakFinder();
            var peak = peakFinder.Find(toFind);

            Assert.AreEqual(15, peak);
        }

        [TestMethod]
        public void Find3()
        {
            var toFind = new int[] { 10, 8, 6, 5, 3, 2 };

            var peakFinder = new OneDimensionsPeakFinder();
            var peak = peakFinder.Find(toFind);

            Assert.AreEqual(10, peak);
        }
    }
}
