using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace HomeTask.Tests
{
    
    public class TwoDimensionalArrayTests
    {
        public static int[,] GetMock(int number)
        {
            int[,] result = new int[0, 0];
            switch (number)
            {
                case 1:
                    result = new int[,]
                    {
                        { 1, 2, 3 },
                        { 4, 5, 6 },
                        { 9, 0, 0 }
                    };
                    break;
                case 2:
                    result = new int[,]
                    {
                        { 1, 50, 3 },
                        { 8, 5, 6 },
                        { 9, 12, 7 }
                    };
                    break;

            }
            return result;
        }

        [TestCase(1, 0)]
        [TestCase(2, 1)]
        public void GetMinimumElementArray_WhenArrayPassed_ShouldReturnMinimumElementArray(int mockNumber, int excpected)
        {
            int[,] array = TwoDimensionalArrayTests.GetMock(mockNumber);
            int actual = TwoDimensionalArray.GetMinValue(array);

            Assert.AreEqual(actual, excpected);
        }


        [TestCase(1, 9)]
        [TestCase(2, 50)]
        public void GetMaximumElementArray_WhenArrayPassed_ShouldReturnMaximumElementArray(int mockNumber, int excpected)
        {
            int[,] array = TwoDimensionalArrayTests.GetMock(mockNumber);
            int actual = TwoDimensionalArray.GetMaxValue(array);

            Assert.AreEqual(actual, excpected);
        }


        [TestCase(1, new int[] { 2, 1 })]
        [TestCase(2, new int[] { 0, 0 })]
        public void GetIndexOfTheMinimumElementArray_WhenArrayPassed_ShouldReturnIndexMinElement(int mockNumber, int[] excpected)
        {
            int[,] array = TwoDimensionalArrayTests.GetMock(mockNumber);
            int[] actual = TwoDimensionalArray.GetMinIndexArray(array);

            Assert.AreEqual(actual, excpected);
        }

        [TestCase(1, new int[] { 2, 0 })]
        [TestCase(2, new int[] { 0, 1 })]
        public void GetIndexOfTheMaximumElementArray_WhenArrayPassed_ShouldReturnIndexMaxElement(int mockNumber, int[] excpected)
        {
            int[,] array = TwoDimensionalArrayTests.GetMock(mockNumber);
            int[] actual = TwoDimensionalArray.GetMaxIndexArray(array);

            Assert.AreEqual(actual, excpected);
        }

        
        [TestCase(1, 5)]
        [TestCase(2, 7)]
        [TestCase(5, 0)]
        public void CountNumberOfElementsGreaterAllNeighbors(int mockNumber, int expected)
        {
            int[,] arr = TwoDimensionalArrayTests.GetMock(mockNumber);
            int actual = TwoDimensionalArray.ElementLargerThanNeighbors(arr);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(3, 3)]
        [TestCase(0, 0)]
        [TestCase(5, 6)]
        public void FlipAnArrayRelativeToItsMainDiagonal_WhenArrayPassed_ShouldReturnRelativeArrayToMainDiagonal(int mockNumber, int mockExpected)
        {
            int[,] array = TwoDimensionalArrayTests.GetMock(mockNumber);
            int[,] expected = TwoDimensionalArrayTests.GetMock(mockExpected);
            int[,] actual = TwoDimensionalArray.TransposeMatrix(array);

            Assert.AreEqual(actual, expected);
        }
    }



}
