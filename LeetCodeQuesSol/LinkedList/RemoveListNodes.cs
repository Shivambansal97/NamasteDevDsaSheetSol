using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.LinkedList
{
    public class RemoveListNodes
    {
        /// <summary>
        /// Problem link: https://leetcode.com/problems/remove-linked-list-elements/
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode temp = head;

            //check the head node
            while(temp!= null && temp.val == val)
            {
                head = temp.next;
                temp = head;
            }

            while (temp != null && temp.next != null) 
            {
                if(temp.next.val == val)
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
