using Algorithms.PeakFinder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Sort
{
    [TestClass]
    public class TwoDimensionsPeakFinderTests
    {
        [TestMethod]
        public void Find1()
        {
            var toFind = new int[,] 
            {
                {  6,  7,  4, 13, 19 },
                {  9,  3, 12, 18, 15 },
                { 23,  8, 14, 17, 20 },
                { 10,  5, 11, 25, 16 },
                { 22, 24,  2,  1, 21 }
            };

            var peakFinder = new TwoDimensionsPeakFinder();
            var peak = peakFinder.Find(toFind);

            Assert.AreEqual(24, peak);
        }

        [TestMethod]
        public void Find2()
        {
            var toFind = new int[,]
            {
                { 10, 8, 10, 10 }, 
                { 14, 13, 12, 11 }, 
                { 15, 9, 11, 21 }, 
                { 16, 17, 19, 20 }
            };

            var peakFinder = new TwoDimensionsPeakFinder();
            var peak = peakFinder.Find(toFind);

            Assert.AreEqual(21, peak);
        }
    }
}
