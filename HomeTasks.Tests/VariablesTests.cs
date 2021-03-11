using HomeTask;
using NUnit.Framework;
using System;

namespace HomeTasks.Tests
{
    public class VariablesTests
    {
        [TestCase(1, 2, 2, 1)]
        [TestCase(0, 2, 2, 0)]
        [TestCase(-1, 2, 2, -1)]
        public void Swap_WhenABPassed_ShouldSwapValues(int a, int b, int expectedA, int expectedB)
        {
            Variables.Swap(ref a, ref b);

            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
        }
        [TestCase(2, 4, 2, 4)]
        [TestCase(1, 3, 1, 3)]
        [TestCase(-1, 7, -1, 7)]
        public void EquationSolution_WhenABValidPassed_ShouldEquationValues(int a, int b, int expectedA, int expectedB)
        {
            Variables.EquationSolution(a, b);
            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
        }
        
        [TestCase(1, 4, 1, 4)]
        [TestCase(-2, -4, -2, -4)]
        [TestCase(6, -4, 6, -4)]
        public void OutputResultAndRemainder_WhenABValidPassed_ShouldResultAndRemainder(int a, int b, int expectedA, int expectedB)
        {
            Variables.OutputResultAndRemainder(a, b);

            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
        }

        [Test]
        
        public void CalculateLinearEquation_WhenABC_ValidPassed_ShouldCalculateWithExeption()
        {
            Assert.Throws<DivideByZeroException>(() => Variables.CalculateLinearEquation(0, 1, 2));
        }

        [TestCase(1, 3, 3, 1, 3, 3)]
        [TestCase(9, 3, 3, 9, 3, 3)]
        [TestCase(12, 23, 23, 12, 23, 23)]
        public void CalculateLinearEquation_WhenABC_ValidPassed_ShouldCalculate(int a, int b, int c, int expectedA, int expectedB, int expectedC)
        {
            Variables.OutputResultAndRemainder(a, b);

            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
            Assert.AreEqual(expectedC, c);
        }

        [TestCase(2, 4, 3, 6)]
        public void GetStraightLineEquation_WhenX1_Y2_X2_Y1_ValidPassed_ShouldShowSolutionLineEquation(int X1, int Y2, int X2, int Y1)
        {
            (int actualA, int actualB) = Variables.GetStraightLineEquation(X1, Y2, X2, Y1);

            Assert.AreEqual(2, actualA);
            Assert.AreEqual(0, actualB);

        }
    }
    }
