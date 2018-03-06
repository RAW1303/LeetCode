namespace Raw.LeetCode.Code.Utilities
{
    using System.Collections.Generic;

    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x) { val = x; }

        public ListNode(int[] intArray)
        {
            this.val = intArray[0];
            ListNode previousNode = this;

            for (int i = 1; i < intArray.Length; i++)
            {
                ListNode currentNode = new ListNode(intArray[i]);
                previousNode.next = currentNode;
                previousNode = currentNode;
            }
        }

        public int[] ToArray()
        {
            List<int> list = new List<int>();
            ListNode currentNode = this;

            while (currentNode != null)
            {
                list.Add(currentNode.val);
                currentNode = currentNode.next;
            }

            return list.ToArray();
        }
    }
}
