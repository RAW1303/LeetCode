namespace Raw.LeetCode.Test.Problems.Algorithms
{
    using System;
    using NUnit.Framework;
    using Code.Problems.Algorithms.Easy;

    [TestFixture]
    class TwoSumTests
    {
        [TestCase(new int[] { 2, 7, 11, 15 }, 9, ExpectedResult = new int[] { 0, 1 }, TestName = "Basic")]
        [TestCase(new int[] { -2, -7, 11, 15 }, 9, ExpectedResult = new int[] { 0, 2 }, TestName = "Negative numbers")]
        [TestCase(new int[] { 4, 9, 3, 5, 0 }, 8, ExpectedResult = new int[] { 2, 3 }, TestName = "Use each number only once")]
        [TestCase(new int[] { 4, 7, 11, 5, 4 }, 8, ExpectedResult = new int[] { 0, 4 }, TestName = "Same number")]
        [TestCase(new int[] { 4, 7, 7, 11, 5, 4 }, 8, ExpectedResult = new int[] { 0, 5 }, TestName = "Duplicate Number")]
        public int[] TestSolution(int[] nums, int target)
        {
            return TwoSum.Solution(nums, target);
        }

        [TestCase(new int[] { 4, 7, 7, 11, 5 }, 8, typeof(ArgumentException), TestName = "No result")]
        public void TestSolutionThrows(int[] nums, int target, Type exceptionType)
        {
            Assert.That(() => TwoSum.Solution(nums, target), Throws.InstanceOf(exceptionType));
        }
    }
}
