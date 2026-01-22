using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.LinkedList
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/rotate-list/
    /// </summary>
    public class RotateRightSol
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if(head == null || head.next == null || k == 0)
            {
                return head;
            }

            int len = 1;

            ListNode tail = head;

            while(tail.next != null)
            {
                tail = tail.next;
                len++;
            }

            k = k % len;

            if(k == 0)
            {
                return head;
            }

            tail.next = head;

            // Find the new tail: (length - k - 1)th node
            ListNode newTail = head;
            for (int i = 0; i < len - k - 1; i++)
            {
                newTail = newTail.next;
            }

            ListNode newHead = newTail.next;
            newTail.next = null;

            return newHead;
        }
    }
}
