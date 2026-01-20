using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.LinkedList
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/intersection-of-two-linked-lists/
    /// </summary>
    public class IntersectionOfTwoList
    {
        //Optimal Solution -> O(n+m),O(1)
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null) return null;

            ListNode a = headA;
            ListNode b = headB;

            while (a != b)
            {
                a = (a == null) ? headB : a.next;
                b = (b == null) ? headA : b.next;
            }

            return a; // or b, both are same at intersection or null if no intersection
        }

        //Using Hashset -> O(n+m),O(n)
        //public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        //{
        //    HashSet<ListNode> set = new();

        //    while(headA != null)
        //    {
        //        set.Add(headA);
        //        headA = headA.next;
        //    }

        //    while(headB != null)
        //    {
        //        if (set.Contains(headB))
        //        {
        //            return headB;
        //        }
        //        headB = headB.next;
        //    }

        //    return null;
        //}
    }
}
