using LeetCodeQuesSol.LinkedList;
using Xunit;
using System.Collections.Generic;

namespace LeetCodeQuesSol.Test.LinkedList
{
    public class ReverseListSolTests
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
        public void Test_EmptyList()
        {
            var sol = new ReverseListSol();
            ListNode head = null;
            var reversed = sol.ReverseList(head);
            Assert.Null(reversed);
        }

        [Fact]
        public void Test_SingleNode()
        {
            var sol = new ReverseListSol();
            var head = BuildList(42);
            var reversed = sol.ReverseList(head);
            Assert.Equal(new[] { 42 }, ListToArray(reversed));
        }

        [Fact]
        public void Test_TwoNodes()
        {
            var sol = new ReverseListSol();
            var head = BuildList(1, 2);
            var reversed = sol.ReverseList(head);
            Assert.Equal(new[] { 2, 1 }, ListToArray(reversed));
        }

        [Fact]
        public void Test_MultipleNodes()
        {
            var sol = new ReverseListSol();
            var head = BuildList(1, 2, 3, 4, 5);
            var reversed = sol.ReverseList(head);
            Assert.Equal(new[] { 5, 4, 3, 2, 1 }, ListToArray(reversed));
        }

        [Fact]
        public void Test_NegativeAndLargeValues()
        {
            var sol = new ReverseListSol();
            var head = BuildList(-5000, 0, 5000);
            var reversed = sol.ReverseList(head);
            Assert.Equal(new[] { 5000, 0, -5000 }, ListToArray(reversed));
        }
    }
}
