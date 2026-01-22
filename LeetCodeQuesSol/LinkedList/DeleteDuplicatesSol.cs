using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.LinkedList
{
    public class DeleteDuplicatesSol
    {
        /// <summary>
        /// Problem link: https://leetcode.com/problems/remove-duplicates-from-sorted-list/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode temp = head;

            while(temp != null && temp.next != null)
            {
                if(temp.next.val == temp.val)
                {
                    temp.next = temp.next.next;
                }
                else
                {
                    temp = temp.next;
                }
            }

            return head;
        }
    }
}
