namespace Raw.LeetCode.Test.Problems.Algorithms.Easy
{
    using NUnit.Framework;
    using Code.Problems.Algorithms.Easy;
    using Code.Utilities;

    [TestFixture]
    class MergeTwoSortedListsTests
    {
        [TestCase(new int[] { 1,2,4 }, new int[] { 1, 3, 4 }, ExpectedResult = new int[] { 1, 1, 2, 3, 4, 4 }, TestName = "Basic")]
        [TestCase(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4, 5, 6, 7 }, ExpectedResult = new int[] { 1, 1, 2, 3, 4, 4, 5, 6, 7 }, TestName = "Different Lengths")]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 1 }, ExpectedResult = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, TestName = "All the same")]
        public int[] TestSolution(int[] l1, int[] l2)
        {
            ListNode node1 = new ListNode(l1);
            ListNode node2 = new ListNode(l2);
            return MergeTwoSortedLists.Solution(node1, node2).ToArray();
        }
    }
}
