using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingTest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingTest.Tests
{
    [TestClass()]
    public class ExistsInArrayTests
    {
        [TestMethod()]
        public void ExistsBinarySearchTest()
        {
            int[] numArray = new int[] { 3, 6, 2, 9, -1, 10 };

            Assert.IsTrue(ExistsInArray.ExistsSequential(numArray, 9));
            Assert.IsFalse(ExistsInArray.ExistsSequential(numArray, 5));

            int[] ints = { -9, 14, 37, 102 };
            
            Assert.IsTrue(ExistsInArray.ExistsSequential(ints, 102));
            Assert.IsFalse(ExistsInArray.ExistsSequential(ints, 36));

            Assert.IsTrue(ExistsInArray.ExistsBinarySearch(ints, 102));
            Assert.IsFalse(ExistsInArray.ExistsBinarySearch(ints, 36));
        }
        
        [TestMethod()]
        public void ExistsBinarySearchLongTest()
        {
            Random randNum = new Random();
            int[] test2 = Enumerable
                .Repeat(0, 10000)
                .Select(i => randNum.Next(-10000, 10000))
                .OrderBy(i => i)
                .ToArray();

            Assert.IsTrue(ExistsInArray.ExistsSequential(test2, test2[333]));
            Assert.IsTrue(ExistsInArray.ExistsBinarySearch(test2, test2[333]));
        }
    }
}