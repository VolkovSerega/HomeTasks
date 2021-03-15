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

                case 3:
                    result = new int[,]
                    {
                        {1, 4, 9 },
                        {2, 5, 0},
                        {3, 6, 0 }
                    };
                    break;
                case 4:
                    result = new int[,]
                    {
                        {1, 8, 9},
                        {50, 5, 12},
                        {3, 6, 7}
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

        [TestCase(null)]
        [TestCase(7)]
        public void OutputMinElementsSecondArrays_WhenAraayLenghtIOrLenghtJorAraayNull_ShoudReternArgumentException(int mockNumber)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int[,] array = TwoDimensionalArrayTests.GetMock(mockNumber);

                TwoDimensionalArray.GetMinValue(array);
            });
        }


        [TestCase(1, 9)]
        [TestCase(2, 50)]
        public void GetMaximumElementArray_WhenArrayPassed_ShouldReturnMaximumElementArray(int mockNumber, int excpected)
        {
            int[,] array = TwoDimensionalArrayTests.GetMock(mockNumber);
            int actual = TwoDimensionalArray.GetMaxValue(array);

            Assert.AreEqual(actual, excpected);
        }

        [TestCase(null)]
        [TestCase(7)]
        public void OutputMaxnElementsSecondArrays_WhenAraayLenghtIOrLenghtJorAraayNull_ShoudReternArgumentException(int mockNumber)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int[,] array = TwoDimensionalArrayTests.GetMock(mockNumber);

                TwoDimensionalArray.GetMaxValue(array);
            });
        }


        [TestCase(1, new int[] { 2, 1 })]
        [TestCase(2, new int[] { 0, 0 })]
        public void GetIndexOfTheMinimumElementArray_WhenArrayPassed_ShouldReturnIndexMinElement(int mockNumber, int[] excpected)
        {
            int[,] array = TwoDimensionalArrayTests.GetMock(mockNumber);
            int[] actual = TwoDimensionalArray.GetMinIndexArray(array);

            Assert.AreEqual(actual, excpected);
        }

        [TestCase(null)]
        [TestCase(7)]
        public void OutputIndexMinElementsSecondArrays_WhenAraayLenghtIOrLenghtJorAraayNull_ShoudReternArgumentException(int mockNumber)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int[,] array = TwoDimensionalArrayTests.GetMock(mockNumber);

                TwoDimensionalArray.GetMinIndexArray(array);
            });
        }

        [TestCase(1, new int[] { 2, 0 })]
        [TestCase(2, new int[] { 0, 1 })]
        public void GetIndexOfTheMaximumElementArray_WhenArrayPassed_ShouldReturnIndexMaxElement(int mockNumber, int[] excpected)
        {
            int[,] array = TwoDimensionalArrayTests.GetMock(mockNumber);
            int[] actual = TwoDimensionalArray.GetMaxIndexArray(array);

            Assert.AreEqual(actual, excpected);
        }

        [TestCase(null)]
        [TestCase(7)]
        public void OutputIdexMaxElementsSecondArrays_WhenAraayLenghtIOrLenghtJorAraayNull_ShoudReternArgumentException(int mockNumber)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int[,] array = TwoDimensionalArrayTests.GetMock(mockNumber);

                TwoDimensionalArray.GetMaxIndexArray(array);
            });
        }


        [TestCase(1, 2)]
        [TestCase(2, 2)]
        [TestCase(3, 2)]
        public void FindingNumberMaxElementsSecond_WhenAraaysLoaded_ShoudReternCountsBiggestElementsForNeighbors(int mockNumber, int expected)
        {
            int[,] array = TwoDimensionalArrayTests.GetMock(mockNumber);

            int actual = TwoDimensionalArray.FindingNumberMaxElementsSecond(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(7)]
        public void FindingNumberMaxElementsSecond_WhenAraayLenghtIOrLenghtJorAraayNull_ShoudReternArgumentException(int mockNumber)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int[,] array = TwoDimensionalArrayTests.GetMock(mockNumber);

                TwoDimensionalArray.FindingNumberMaxElementsSecond(array);
            });
        }


        [TestCase(1, 3)]
        [TestCase(2, 4)]
        public void OutputTransposeMatrix_WhenAraaysLoaded_ShoudReternTransposeMatrix(int mockNumber, int mockNumber1)
        {
            int[,] array = TwoDimensionalArrayTests.GetMock(mockNumber);

            int[,] expected = TwoDimensionalArrayTests.GetMock(mockNumber1);

            int[,] actual = TwoDimensionalArray.TransposeMatrix(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(7)]
        public void OutputTransposeMatrix_WhenAraayLenghtIOrLenghtJorAraayNull_ShoudReternArgumentException(int mockNumber)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int[,] array = TwoDimensionalArrayTests.GetMock(mockNumber);

                TwoDimensionalArray.TransposeMatrix(array);
            });
        }
    }



}
