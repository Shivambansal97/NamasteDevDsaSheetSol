using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.LinkedList
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/palindrome-linked-list/
    /// </summary>
    public class PalindromeList
    {
        //using list reversal O(n), O(1)
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
                return true;

            // Find the middle
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // Reverse the second half
            ListNode prev = null, curr = slow;
            while (curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }

            // Compare both halves
            ListNode first = head, second = prev;
            while (second != null)
            {
                if (first.val != second.val)
                    return false;
                first = first.next;
                second = second.next;
            }

            return true;
        }

        //Using Stack O(n),O(n)
        //public bool IsPalindrome(ListNode head)
        //{
        //    if (head == null || head.next == null)
        //    {
        //        return true;
        //    }

        //    Stack<ListNode> st = new();

        //    ListNode slow = head;
        //    ListNode fast = head;

        //    while (fast != null && fast.next != null)
        //    {
        //        st.Push(slow);
        //        slow = slow.next;
        //        fast = fast.next.next;
        //    }

        //    //skip the middle node for odd length list
        //    if (fast != null)
        //    {
        //        slow = slow.next;
        //    }

        //    while (slow != null)
        //    {
        //        if(st.Pop().val != slow.val)
        //        {
        //            return false;
        //        }
        //        slow = slow.next;
        //    }

        //    return true;
        //}
    }
}
