using LeetCodeQuesSol.LinkedList;
using Xunit;
using System.Collections.Generic;

namespace LeetCodeQuesSol.Tests.LinkedList
{
    public class AddTwoNumSolTests
    {
        private ListNode BuildList(params int[] values)
        {
            ListNode dummy = new ListNode(0);
            ListNode curr = dummy;
            foreach (var v in values)
            {
                curr.next = new ListNode(v);
                curr = curr.next;
            }
            return dummy.next;
        }

        private int[] ListToArray(ListNode node)
        {
            var result = new List<int>();
            while (node != null)
            {
                result.Add(node.val);
                node = node.next;
            }
            return result.ToArray();
        }

        [Fact]
        public void Test_SimpleAddition_NoCarry()
        {
            var sol = new AddTwoNumSol();
            var l1 = BuildList(2, 4, 3); // 342
            var l2 = BuildList(5, 6, 4); // 465
            var result = sol.AddTwoNumbers(l1, l2);
            Assert.Equal(new[] { 7, 0, 8 }, ListToArray(result)); // 807
        }

        [Fact]
        public void Test_SimpleAddition_WithCarry()
        {
            var sol = new AddTwoNumSol();
            var l1 = BuildList(9, 9, 9);
            var l2 = BuildList(1);
            var result = sol.AddTwoNumbers(l1, l2);
            Assert.Equal(new[] { 0, 0, 0, 1 }, ListToArray(result)); // 1000
        }

        [Fact]
        public void Test_DifferentLengths()
        {
            var sol = new AddTwoNumSol();
            var l1 = BuildList(1, 8); // 81
            var l2 = BuildList(0);    // 0
            var result = sol.AddTwoNumbers(l1, l2);
            Assert.Equal(new[] { 1, 8 }, ListToArray(result));
        }

        [Fact]
        public void Test_OneNodeEach()
        {
            var sol = new AddTwoNumSol();
            var l1 = BuildList(5);
            var l2 = BuildList(5);
            var result = sol.AddTwoNumbers(l1, l2);
            Assert.Equal(new[] { 0, 1 }, ListToArray(result));
        }

        [Fact]
        public void Test_LargeNumbers()
        {
            var sol = new AddTwoNumSol();
            var l1 = BuildList(9,9,9,9,9,9,9); // 9,999,999
            var l2 = BuildList(9,9,9,9);       // 9,999
            var result = sol.AddTwoNumbers(l1, l2);
            Assert.Equal(new[] {8,9,9,9,0,0,0,1}, ListToArray(result)); // 10,009,998
        }
    }
}
