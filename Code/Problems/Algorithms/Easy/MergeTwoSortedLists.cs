namespace Raw.LeetCode.Code.Problems.Algorithms.Easy
{
    using System;
    using System.Collections.Generic;

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

            while(currentNode != null)
            {
                list.Add(currentNode.val);
                currentNode = currentNode.next;
            }

            return list.ToArray();
        }
    }
}
