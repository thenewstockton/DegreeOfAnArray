using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DegreeOfAnArray;


namespace DegreeOfAnArrayTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution solution = new Solution();
            int[] array = { 1, 2, 2, 3, 1 };
            Assert.AreEqual(2, solution.FindShortestSubArray(array));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Solution solution = new Solution();
            int[] array = { 1, 2, 2, 3, 1, 4, 2 };
            Assert.AreEqual(6, solution.FindShortestSubArray(array));
        }
    }
}
