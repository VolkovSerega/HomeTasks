using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace HomeTasks.Tests
{
    public class BranchingStructuresTests
    {
        [TestCase(1, 2, -1)]
        [TestCase(2, 2, 4)]
        [TestCase(2, 1, 3)]
        public void EvaluateGivenArguments_WhenAB_Passed_ShoulRezultEvaluate(int a, int b, int expected)
        {
            int actual = BranchingStructures.EvaluateGivenArguments(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, -1)]
        [TestCase(-4, 2, -6)]
        [TestCase(100, 8, 108)]
        public void DefineLocationInQuarter_WhenXY_Passed_ShouldLocationRezult(int x, int y, int expected)
        {
            int actual = BranchingStructures.EvaluateGivenArguments(x, y);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, 1, 7, new int[] { 1, 2, 7 })]
        [TestCase(-7, -1, -17, new int[] { -17, -7, -1 })]
        [TestCase(21, -9, 67, new int[] { -9, 21, 67 })]
        public void SortingThreeElements_WhenABC_Passed_ShouldSortInAscendingOrder(int a, int b, int c, int[] ar)
        {
            int[] actual = BranchingStructures.SortingThreeElements(a, b, c);
            Assert.AreEqual(ar, actual);

        }

        [TestCase(2, 4, 0, new double[] { -2, 0 })]
        [TestCase(1, 0, 0, new double[] { 0 })]
        [TestCase(5, 0, 3, new double[] { })]
        public void GetQuadraticEquationSolvingWhenABCShouldSolvQuadraticEquation(double a, double b, double c, double[] expected)
        {
            double[] actual = BranchingStructures.GetQadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, "Десять")]
        [TestCase(25, "Двадцать пять")] 
        [TestCase(86, "Восемьдесят шесть")]
        [TestCase(91, "Девяносто один")]
        public void GetNumberWritingWhenNiumberPassedShouldPrintAnUppercaseEntry(int num, string expectednumWriting)
        {
            string actualnumWriting = BranchingStructures.GetNumberWriting(num);
            Assert.AreEqual(expectednumWriting, actualnumWriting);
        }
    }
}
