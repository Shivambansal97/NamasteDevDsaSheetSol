using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.LinkedList
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    public class AddTwoNumSol
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;

            ListNode sumListHead = new(0);

            ListNode sumList = sumListHead;

            while(l1 != null && l2 != null)
            {
                int tempSum = l1.val + l2.val + carry;

                carry = tempSum / 10;
                tempSum = tempSum % 10;

                sumList.next = new(tempSum);

                l1 = l1.next;
                l2 = l2.next;
                sumList = sumList.next;
            }

            while(l1 != null)
            {
                int tempSum = l1.val + carry;

                carry = tempSum / 10;
                tempSum %= 10;

                sumList.next = new(tempSum);

                l1 = l1.next;
                sumList = sumList.next;
            }

            while (l2 != null)
            {
                int tempSum = l2.val + carry;

                carry = tempSum / 10;
                tempSum %= 10;

                sumList.next = new(tempSum);

                l2 = l2.next;
                sumList = sumList.next;
            }

            if(carry != 0)
            {
                sumList.next = new(carry);
            }

            return sumListHead.next;
        }
    }
}
