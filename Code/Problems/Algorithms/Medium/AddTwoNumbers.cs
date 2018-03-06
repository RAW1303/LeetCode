namespace Raw.LeetCode.Code.Problems.Algorithms.Medium
{
    using Raw.LeetCode.Code.Utilities;

    public static class AddTwoNumbers
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            ListNode fullSum = new ListNode(-1);
            ListNode currentNode = fullSum;
            int carry = 0;

            while(l1 != null || l2 != null || carry > 0)
            {
                int l1Val = l1 != null ? l1.val : 0;
                int l2Val = l2 != null ? l2.val : 0;
                int sum = l1Val + l2Val + carry;

                carry = sum / 10;
                currentNode.next = new ListNode(sum % 10);

                l1 = l1?.next;
                l2 = l2?.next;
                currentNode = currentNode.next;
            }

            return fullSum.next;
        }
    }
}
