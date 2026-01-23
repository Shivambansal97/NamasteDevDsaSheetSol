using LeetCodeQuesSol.LinkedList;
using Xunit;
using System.Collections.Generic;

namespace LeetCodeQuesSol.Tests.LinkedList
{
    public class OddEvenListSolTests
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
            var sol = new OddEvenListSol();
            ListNode head = null;
            var result = sol.OddEvenList(head);
            Assert.Null(result);
        }

        [Fact]
        public void Test_SingleNode()
        {
            var sol = new OddEvenListSol();
            var head = BuildList(42);
            var result = sol.OddEvenList(head);
            Assert.Equal(new[] { 42 }, ListToArray(result));
        }

        [Fact]
        public void Test_TwoNodes()
        {
            var sol = new OddEvenListSol();
            var head = BuildList(1, 2);
            var result = sol.OddEvenList(head);
            Assert.Equal(new[] { 1, 2 }, ListToArray(result));
        }

        [Fact]
        public void Test_OddLengthList()
        {
            var sol = new OddEvenListSol();
            var head = BuildList(1, 2, 3, 4, 5);
            var result = sol.OddEvenList(head);
            Assert.Equal(new[] { 1, 3, 5, 2, 4 }, ListToArray(result));
        }

        [Fact]
        public void Test_EvenLengthList()
        {
            var sol = new OddEvenListSol();
            var head = BuildList(2, -3, 4, 5, 6, 7);
            var result = sol.OddEvenList(head);
            Assert.Equal(new[] { 2, 4, 6, -3, 5, 7 }, ListToArray(result));
        }

        [Fact]
        public void Test_NegativeAndLargeValues()
        {
            var sol = new OddEvenListSol();
            var head = BuildList(-106, 0, 106);
            var result = sol.OddEvenList(head);
            Assert.Equal(new[] { -106, 106, 0 }, ListToArray(result));
        }
    }
}
