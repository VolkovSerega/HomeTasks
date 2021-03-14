using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace HomeTasks.Tests
{
    public class ArrayTests
    {
        [TestCase (new int[] {1, 3, 4}, 1)]
        public void GetMinimalElementOfArray(int[] array, int[] expected)
        {
            Assert.AreEqual(expected, Array.GetMinimalElementOfArray(array));
        }
    }
}
