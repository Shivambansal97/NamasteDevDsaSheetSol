using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.LinkedList
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/odd-even-linked-list/
    /// </summary>
    public class OddEvenListSol
    {
        public ListNode OddEvenList(ListNode head)
        {
            if(head == null)
            {
                return head;
            }

            ListNode odd = head;
            ListNode temp = head.next;

            ListNode even = temp;

            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }

            odd.next = temp;

            return head;
        }
    }
}
