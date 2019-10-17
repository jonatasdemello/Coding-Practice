using System;
using CodingTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class OddOccurrencesInArrayTest
    {
        [TestMethod]
        public void test_OddOccurrencesInArray()
        {
            // Arrange
            var input = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            var output = 7;
            //Act
            var result = OddOccurrencesInArray.Solution(input);
            //Assert
            Assert.AreEqual(result, output);
        }
    }
}
