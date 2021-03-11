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
            int actual = BranchingStructures.EvaluateGivenArguments(x , y);
            Assert.AreEqual(expected, actual);
        }
    }
}
