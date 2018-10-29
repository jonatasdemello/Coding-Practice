using System;
using CodingTest01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BinaryGapTest
    {
        [TestMethod]
        public void when_9_should_return_2()
        {
            Assert.AreEqual(BinaryGap.Solution(9), 2); // 1001
        }
        [TestMethod]
        public void when_2_should_return_0()
        {
            Assert.AreEqual(BinaryGap.Solution(2), 0); // 0010
        }
        [TestMethod]
        public void when_4_should_return_0()
        {
            Assert.AreEqual(BinaryGap.Solution(4), 0); // 0100
        }
        [TestMethod]
        public void when_5_should_return_1()
        {
            Assert.AreEqual(BinaryGap.Solution(5), 1); // 0101
        }
        [TestMethod]
        public void when_12_should_return_0()
        {
            Assert.AreEqual(BinaryGap.Solution(12), 0); // 1100
        }
        [TestMethod]
        public void when_1041_should_return_5()
        {
            Assert.AreEqual(BinaryGap.Solution(1041), 5); // ‭010000010001‬
        }
        [TestMethod]
        public void when_0_should_return_0()
        {
            Assert.AreEqual(BinaryGap.Solution(0), 0); // 0
        }
        [TestMethod]
        public void when_511_should_return_0()
        {
            Assert.AreEqual(BinaryGap.Solution(511), 0); // ‭000111111111‬
        }
        [TestMethod]
        public void when_126_should_return_0()
        {
            Assert.AreEqual(BinaryGap.Solution(126), 0); // ‭01111110‬
        }
        [TestMethod]
        public void when_12320_should_return_6()
        {
            Assert.AreEqual(BinaryGap.Solution(12320), 6); // ‭0011000000100000‬
        }
    }
}
