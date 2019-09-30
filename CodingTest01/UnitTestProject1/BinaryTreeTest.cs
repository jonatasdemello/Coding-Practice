using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using CodingTest01;

namespace UnitTestProject1
{
    [TestClass]
    public class BinaryTreeTest
    {
        [TestMethod]
        public void BranchSize_should_return_Left()
        {
            long[] numArray = new long[] { 3, 6, 2, 9, -1, 10 };
            var result = BranchSize.Solution(numArray);
            Assert.AreEqual(result, "Left");
        }
        [TestMethod]
        public void BranchSize_should_return_Right()
        {
            long[] numArray = new long[] { 1, 4, 100, 5 };
            var result = BranchSize.Solution(numArray);
            Assert.AreEqual(result, "Right");
        }
        [TestMethod]
        public void BranchSize_should_return_empty1()
        {
            long[] numArray = new long[] { 1, 10, 5, 1, 0, 6 };
            var result = BranchSize.Solution(numArray);
            Assert.AreEqual(result, "");
        }
        [TestMethod]
        public void BranchSize_should_return_empty2()
        {
            long[] numArray = new long[] { };
            var result = BranchSize.Solution(numArray);
            Assert.AreEqual(result, "");
        }
        [TestMethod]
        public void BranchSize_should_return_empty3()
        {
            long[] numArray = new long[] { 1 };
            var result = BranchSize.Solution(numArray);
            Assert.AreEqual(result, "");
        }
    }
}
