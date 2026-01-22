using LeetCodeQuesSol.LinkedList;
using System;
using Xunit;

namespace LeetCodeQuesSol.Tests.LinkedList
{
    public class SwapPairSolTests
    {
        private ListNode BuildList(params int[] values)
        {
            if (values.Length == 0) return null;
            var head = new ListNode(values[0]);
            var current = head;
            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }
            return head;
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
            var sol = new SwapPairSol();
            var result = sol.SwapPairs(null);
            Assert.Null(result);
        }

        [Fact]
        public void Test_SingleNode()
        {
            var sol = new SwapPairSol();
            var head = BuildList(42);
            var result = sol.SwapPairs(head);
            Assert.Equal(new[] { 42 }, ListToArray(result));
        }

        [Fact]
        public void Test_TwoNodes()
        {
            var sol = new SwapPairSol();
            var head = BuildList(1, 2);
            var result = sol.SwapPairs(head);
            Assert.Equal(new[] { 2, 1 }, ListToArray(result));
        }

        [Fact]
        public void Test_OddNodes()
        {
            var sol = new SwapPairSol();
            var head = BuildList(1, 2, 3);
            var result = sol.SwapPairs(head);
            Assert.Equal(new[] { 2, 1, 3 }, ListToArray(result));
        }

        [Fact]
        public void Test_EvenNodes()
        {
            var sol = new SwapPairSol();
            var head = BuildList(1, 2, 3, 4);
            var result = sol.SwapPairs(head);
            Assert.Equal(new[] { 2, 1, 4, 3 }, ListToArray(result));
        }

        [Fact]
        public void Test_BoundaryValues()
        {
            var sol = new SwapPairSol();
            var head = BuildList(0, 100, 50, 100);
            var result = sol.SwapPairs(head);
            Assert.Equal(new[] { 100, 0, 100, 50 }, ListToArray(result));
        }
    }
}
