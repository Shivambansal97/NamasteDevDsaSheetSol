using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.LinkedList
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/swap-nodes-in-pairs/
    /// </summary>
    public class SwapPairSol
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode prev = new();
            prev.next = head;

            ListNode newHead = prev;

            while(prev.next!=null && prev.next.next != null)
            {
                ListNode first = prev.next;
                ListNode second = first.next;

                first.next = second.next;
                second.next = first;
                prev.next = second;

                prev = first;
            }

            return newHead.next;
        }
    }
}
