namespace Raw.LeetCode.Test.Problems.Algorithms.Medium
{
    using NUnit.Framework;
    using Code.Problems.Algorithms.Medium;
    using Code.Utilities;

    class AddTwoNumbersTest
    {
        [TestCase(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, ExpectedResult = new int[] { 7, 0, 8 }, TestName = "Basic")]
        [TestCase(new int[] { 0, 0, 5 }, new int[] { 0, 0, 5 }, ExpectedResult = new int[] { 0, 0, 0, 1 }, TestName = "Carry")]
        [TestCase(new int[] { 0, 0, 5 }, new int[] { 0, 5 }, ExpectedResult = new int[] { 0, 5, 5 }, TestName = "Different lengths")]
        public int[] TestSolution(int[] l1, int[] l2)
        {
            ListNode node1 = new ListNode(l1);
            ListNode node2 = new ListNode(l2);
            return AddTwoNumbers.Solution(node1, node2).ToArray();
        }
    }
}
