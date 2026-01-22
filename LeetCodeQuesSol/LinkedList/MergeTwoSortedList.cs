using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.LinkedList
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/merge-two-sorted-lists/
    /// </summary>
    public class MergeTwoSortedList
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode resultHead = new();
            ListNode result = resultHead;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    result.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    result.next = list2;
                    list2 = list2.next;
                }
                result = result.next;
            }

            while (list1 != null)
            {
                result.next = list1;
                list1 = list1.next;
                result = result.next;
            }

            while (list2 != null)
            {
                result.next = list2;
                list2 = list2.next;
                result = result.next;
            }

            return resultHead.next;
        }
    }
}
