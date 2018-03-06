namespace Raw.LeetCode.Code.Problems.Algorithms.Easy
{
    using Raw.LeetCode.Code.Utilities;

    public static class MergeTwoSortedLists
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            ListNode newListNodeRoot = new ListNode(int.MinValue);
            ListNode newListNodeCurrent = newListNodeRoot;

            while (l1 != null || l2 != null)
            {
                if(l1 != null && (l2 == null || l1.val < l2.val))
                {
                    newListNodeCurrent.next = new ListNode(l1.val);
                    l1 = l1.next;
                }
                else
                {
                    newListNodeCurrent.next = new ListNode(l2.val);
                    l2 = l2.next;
                }

                newListNodeCurrent = newListNodeCurrent.next;
            }

            return newListNodeRoot.next;
        }
    }
}
