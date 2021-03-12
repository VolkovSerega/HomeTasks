using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace HomeTasks.Tests
{
    public class CicleTests
    {
        [TestCase(2, 3, 8)]
        [TestCase(3, 3, 27)]
        [TestCase(-4, 2, 16)]
        public void GetNumberAPowerBResultRaisedNumber(int a, int b, int expected)
        {
            int actual = Cicle.GetNumberAPowerB(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(500, new int[] { 500, 1000 })]
        [TestCase(1000, new int[] { 1000 })]
        [TestCase(200, new int[] { 200, 400, 600, 800, 1000 })]
        public void GetNumbersDivisibleByA(int a, int[] expectedAr)
        {
            int[] actualAr = Cicle.GetNumbersDivisibleByA(a);
            Assert.AreEqual(expectedAr, actualAr);
        }

        [TestCase(99, 10)]
        [TestCase(6, 3)]
        [TestCase(-7, 0)]
        public void GetCountOfNumLessSquareA(int a, int expected)
        {
            int actual = Cicle.GetCountOfNumLessSquareA(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 1)]
        [TestCase(-5, 0)]
        [TestCase(999, 333)]
        public void GetGreatestDivisorWhenBringOutTheDivisor_LessThan_A(int a, int expected)
        {
            int actual = Cicle.GetGreatestDivisor(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(55, 1567, 174636)]
        [TestCase(86, -4, 0)]
        [TestCase(0, 44, 147)]
        public void GetSumOfMultiplesOfSevenWithDiapazoneAForB_DivisionWithoutRemainder(int leftBord, int rightBord, int expected)
        {
            int actual = Cicle.GetSumOfMultiplesOfSeven(leftBord, rightBord);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1)]
        [TestCase(5, 5)]
        [TestCase(14, 377)]
        public void GetNFibonacciNumberWhenN_Passed_PrintN_thNumberOfTheFibonacciSeries(int n, int expected)
        {
            int actual = Cicle.GetNFibonacciNumber(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(32, 12, 4)]
        [TestCase(-5, -6, -1)]
        [TestCase(9, 63, 9)]
        public void GetGreatestDivisorEuclidAlgorithm(int a, int b, int expected)
        {
            int actual = Cicle.GetGreatestDivisorEuclidAlgorithm(a, b);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(64, 4)]
        [TestCase(27, 3)]
        [TestCase(343, 7)]
        public void GetValueWithBinarySearch(int mid, int expected)
        {
            int actual = Cicle.GetValueWithBinarySearch(mid);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(13, 2)]
        [TestCase(-5, 0)]
        [TestCase(11, 2)]
        [TestCase(454, 1)]
        public void GetNumberOfOddDigitsFindTheNumberOfOddDigitsOfThisNumber(int n, int expected)
        {
            int actual = Cicle.GetNumberOfOddDigits(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2345, 5432)]
        [TestCase(85296, 69258)]
        [TestCase(12352, 25321)]
        public void GetMirrorOfNum(int num, int expected)
        {
            int actual = Cicle.GetMirrorOfNum(num);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(24, 11)]
        [TestCase(45, 22)]
        [TestCase(145, 62)]
        public void GetNumbersForWitchSumEvenNumericLessOdd(int a, int expected)
        {
            int actual = Cicle.GetNumbersForWitchSumEvenNumericLessOdd(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(23, 45, false)]
        [TestCase(44, 22, false)]
        [TestCase(40, 44, true)]
        public void GetNumbersSame(int OneNum, int TwoNum, bool expected)
        {
            bool actual = Cicle.GetNumbersSame(OneNum, TwoNum);
            Assert.AreEqual(expected, actual);
        }
    }
}
