namespace Raw.LeetCode.Test.Problems.Algorithms.Easy
{
    using System;
    using NUnit.Framework;
    using Code.Problems.Algorithms.Easy;

    [TestFixture]
    class MergeTwoSortedListsTests
    {
        [TestCase(new int[] { 1,2,4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        public void TestSolution(int[] l1, int[] l2, int[] expected)
        {
            ListNode node1 = new ListNode(l1);
            ListNode node2 = new ListNode(l2);
            Assert.AreEqual(expected, MergeTwoSortedLists.Solution(node1, node2).ToArray());
        }
    }
}
