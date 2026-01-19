using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.LinkedList
{
    public class DetectCycleInList
    {
        public bool HasCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null) 
            {
                slow = slow.next;
                fast = fast.next.next;
                if(fast == slow)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
