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
        public void OutputMinElementsArray_WhenAraaysLoaded_ShoudReternMinElementArrays(int[] a, int expected)
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


        [TestCase(new int[] { 1, 1, 4, 0 }, 4 )]
        [TestCase(new int[] { -5, -1, 3 }, 3)]
        [TestCase(new int[] { -14, 1, 2 }, 2)]
        [TestCase(new int[] { -10, 0, 4 }, 4)]
        public void OutputMaxElementsArray_WhenAraaysLoaded_ShoudReternMaxElementArrays(int[] a, int expected)
        {
            int actual = Array.GetMaximalElementOfArray(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 3, 7, 4, 1 }, 1)]
        [TestCase(new int[] { -9, -1, 5 }, -9)]
        [TestCase(new int[] { -17, 12, 6 }, -17)]
        [TestCase(new int[] { -11, 0, 4 }, -11)]
        public void OutputMaxElementsArray_WhenAraaysLoaded_ShoudReternMaxElementArraysWithException(int[] a, int expected)
        {
            int actual = Array.GetMinimalElementOfArray(a);
            Assert.AreEqual(expected, actual);
        }
    }
}