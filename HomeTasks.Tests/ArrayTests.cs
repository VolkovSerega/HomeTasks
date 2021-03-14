using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace HomeTasks.Tests
{
    public class ArrayTests
    {
        [TestCase(new int[] { 1, 1, 4, 0 }, 0)]
        [TestCase(new int[] { -5, -1, 3 }, -5)]
        [TestCase(new int[] { -14, 1, 2 }, -14)]
        [TestCase(new int[] { -10, 0, 4 }, -10)]
        public void OutputMinElementsArray_WhenAraaysLoaded_ShoudReturnMinElementArrays(int[] a, int expected)
        {
            int actual = Array.GetMinimalElementOfArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 1, 4, 0 }, 0)]
        [TestCase(new int[] { -5, -1, 3 }, -5)]
        [TestCase(new int[] { -14, 1, 2 }, -14)]
        [TestCase(new int[] { -10, 0, 4 }, -10)]
        public void OutputMinElementsArray_WhenAraaysLoaded_ShoudReternMinElementArraysWithException(int[] a, int expected)
        {
            int actual = Array.GetMinimalElementOfArray(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 1, 4, 0 }, 4)]
        [TestCase(new int[] { -5, -1, 3 }, 3)]
        [TestCase(new int[] { -14, 1, 2 }, 2)]
        [TestCase(new int[] { -10, 0, 4 }, 4)]
        public void OutputMaxElementsArray_WhenAraaysLoaded_ShoudReturnMaxElementArrays(int[] a, int expected)
        {
            int actual = Array.GetMaximalElementOfArray(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 3, 7, 4, 1 }, 1)]
        [TestCase(new int[] { -9, -1, 5 }, -9)]
        [TestCase(new int[] { -17, 12, 6 }, -17)]
        [TestCase(new int[] { -11, 0, 4 }, -11)]
        public void OutputMaxElementsArray_WhenAraaysLoaded_ShoudReturnMaxElementArraysWithException(int[] a, int expected)
        {
            int actual = Array.GetMinimalElementOfArray(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 1, 4, 0 }, 3)]
        [TestCase(new int[] { -5, -1, 3, 8 }, 0)]
        [TestCase(new int[] { 100, -14, -101, 2 }, 2)]
        [TestCase(new int[] { -10, 0, -4000, -9000 }, 3)]
        public void GetIndexOfMinimalElementOfArray_WhenAraaysLoaded_ShoudReturnIndexOfMinimalElement(int[] a, int expected)
        {
            int actual = Array.GetIndexOfMinimalElementOfArray(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void OutputIndexMinElementsArray_WhenAraaysNullorLenghtZero_ShoudReternArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Array.GetIndexOfMinimalElementOfArray(array);
            });
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void OutputIndexMaxnElementsArray_WhenAraaysNullorLenghtZero_ShoudReturnArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Array.GetIndexOfMaximalElementOfArray(array);
            });
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 20)]
        [TestCase(new int[] { -5, -1, 3, 88 }, 87)]
        [TestCase(new int[] { 78, -14, -98, 2 }, -12)]
        [TestCase(new int[] { -10, 0, -890, 3600 }, 3600)]
        public void GetSumArrayElementsIsOddIndex_WhenAraaysLoaded_ShoudReternSumElementsWhyIndexOdd(int[] a, int expected)
        {
            int actual = Array.GetSumOddIndexElemArray(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void GetSumArrayElementsIsOddIndex_WhenAraaysNullorLenghtZero_ShoudReturnArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Array.GetSumOddIndexElemArray(array);
            });
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { -5, -1, 3, 88 }, new int[] { 88, 3, -1, -5 })]
        [TestCase(new int[] { 78, -14, -98, 2 }, new int[] { 2, -98, -14, 78 })]
        [TestCase(new int[] { -10, 0, -890, 3600 }, new int[] { 3600, -890, 0, -10 })]
        public void GetReverseArray_WhenAraaysLoaded_ShoudReternReversInputArray(int[] a, int[] expected)
        {
            int[] actual = Array.GetReversArray(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void GetReverseArray_WhenAraaysNullorLenghtZero_ShoudReternArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Array.GetReversArray(array);
            });
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5)]
        [TestCase(new int[] { -7, -3, 1, 6 }, 3)]
        [TestCase(new int[] { 10, -16, -11, 2 }, 1)]
        [TestCase(new int[] { -110, 0, -20, -90 }, 0)]
        public void GetSumOddElemArray_WhenAraaysLoaded_ShoudReternCountsOddElements(int[] a, int expected)
        {
            int actual = Array.GetSumOddElemArray(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void GetSumOddElemArray_WhenAraaysNullorLenghtZero_ShoudReternArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Array.GetSumOddElemArray(array);
            });
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 6, 7, 8, 9, 5, 1, 2, 3, 4 })]
        [TestCase(new int[] { -5, -1, 3, 8 }, new int[] { 3, 8, -5, -1 })]
        [TestCase(new int[] { 100, 0, -101, 2 }, new int[] { -101, 2, 100, 0 })]
        [TestCase(new int[] { -10, 0, -4000, -9000, 1 }, new int[] { -9000, 1, -4000, -10, 0 })]
        public void SwapElemArray_WhenAraaysLoaded_ShoudReternReversArrayForMidl(int[] a, int[] expected)
        {
            int[] actual = Array.SwapElemArray(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void SwapElemArray_WhenAraaysNullorLenghtZero_ShoudReternArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Array.SwapElemArray(array);
            });
        }

        [TestCase(new int[] { -5, -1, 3, 8 }, new int[] { 8, 3, -1, -5 })]
        [TestCase(new int[] { 100, 0, -101, 2 }, new int[] { 100, 2, 0, -101 })]
        [TestCase(new int[] { -110, 0, -20, -90 }, new int[] { 0, -20, -90, -110 })]
        public void SelectionSort(int[] a, int[] expected)
        {
            int[] actual = Array.SelectionSort(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void SelectionSort_WhenAraaysNullorLenghtZero_ShoudReternArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Array.SelectionSort(array);
            });
        }
    }
}