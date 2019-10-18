using System;
using CodingTest;
using CodingTest.Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class CyclicRotationTest
    {
        [TestMethod]
        public void test_CyclicRotation_by_one()
        {
            // Arrange
            var input = new int[] { 3, 8, 9, 7, 6 };
            var output = new int[] { 6, 3, 8, 9, 7 };
            //Act
            var result = CyclicRotation.Solution(input, 1);
            //Assert
            CollectionAssert.AreEqual(result, output);
        }
        [TestMethod]
        public void test_CyclicRotation_by_two()
        {
            // Arrange
            var input = new int[] { 1, 2, 3, 4, 5 };
            var output = new int[] { 4, 5, 1, 2, 3 };
            //Act
            var result = CyclicRotation.Solution(input, 2);
            //Assert
            CollectionAssert.AreEqual(result, output);
        }
        [TestMethod]
        public void test_CyclicRotation_by_three()
        {
            // Arrange
            var input = new int[] { 3, 8, 9, 7, 6 };
            var output = new int[] { 9, 7, 6, 3, 8 };
            //Act
            var result = CyclicRotation.Solution(input, 3);
            //Assert
            CollectionAssert.AreEqual(result, output);
        }
        [TestMethod]
        public void test_CyclicRotation_double()
        {
            // Arrange
            var input = new int[] { 5, -1000 };
            var output = new int[] { -1000, 5 };
            //Act
            var result = CyclicRotation.Solution(input, 1);
            //Assert
            CollectionAssert.AreEqual(result, output);
        }
        [TestMethod]
        public void test_CyclicRotation_small()
        {
            // Arrange
            var input = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var output = new int[] { 6, 7, 1, 2, 3, 4, 5 };
            //Act
            var result = CyclicRotation.Solution(input, 2);
            //Assert
            CollectionAssert.AreEqual(result, output);
        }
        [TestMethod]
        public void when_array_is_empty()
        {
            // Arrange
            var input = new int[] { };
            var output = new int[] { };
            //Act
            var result = CyclicRotation.Solution(input, 1);
            //Assert
            CollectionAssert.AreEqual(result, output);
        }
        [TestMethod]
        public void when_k_is_greater_than_n()
        {
            // Arrange
            var input = new int[] { 1, 1, 2, 3, 5 };
            var output = new int[] { 3, 5, 1, 1, 2 };
            //Act
            var result = CyclicRotation.Solution(input, 42);
            //Assert
            CollectionAssert.AreEqual(result, output);
        }
        [TestMethod]
        public void when_array_is_one_return_same()
        {
            // Arrange
            var input = new int[] { 1 };
            var output = new int[] { 1 };
            //Act
            var result = CyclicRotation.Solution(input, 1);
            //Assert
            CollectionAssert.AreEqual(result, output);
        }
        [TestMethod]
        public void when_array_is_same_number_return_same()
        {
            // Arrange
            var input = new int[] { 0, 0, 0 };
            var output = new int[] { 0, 0, 0 };
            //Act
            var result = CyclicRotation.Solution(input, 1);
            //Assert
            CollectionAssert.AreEqual(result, output);
        }
        [TestMethod]
        public void when_num_is_same_as_array_len_return_same()
        {
            // Arrange
            var input = new int[] { 1, 2, 3, 4 };
            var output = new int[] { 1, 2, 3, 4 };
            //Act
            var result = CyclicRotation.Solution(input, 4);
            //Assert
            CollectionAssert.AreEqual(result, output);
        }
        [TestMethod]
        public void when_num_is_zero_should_return_same()
        {
            // Arrange
            var input = new int[] { 1, 2, 3, 4 };
            var output = new int[] { 1, 2, 3, 4 };
            //Act
            var result = CyclicRotation.Solution(input, 0);
            //Assert
            CollectionAssert.AreEqual(result, output);
        }
        [TestMethod]
        public void when_num_is_negative_should_return_same()
        {
            // Arrange
            var input = new int[] { 1, 2, 3, 4 };
            var output = new int[] { 1, 2, 3, 4 };
            //Act
            var result = CyclicRotation.Solution(input, -1);
            //Assert
            CollectionAssert.AreEqual(result, output);
        }
    }
}
