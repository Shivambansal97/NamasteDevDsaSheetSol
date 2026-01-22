using LeetCodeQuesSol.LinkedList;
using System;
using Xunit;

namespace LeetCodeQuesSol.Tests.LinkedList
{
    public class RotateRightSolTests
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
            var sol = new RotateRightSol();
            var result = sol.RotateRight(null, 1);
            Assert.Null(result);
        }

        [Fact]
        public void Test_SingleNode()
        {
            var sol = new RotateRightSol();
            var head = BuildList(5);
            var result = sol.RotateRight(head, 3);
            Assert.Equal(new[] { 5 }, ListToArray(result));
        }

        [Fact]
        public void Test_KZero()
        {
            var sol = new RotateRightSol();
            var head = BuildList(1, 2, 3);
            var result = sol.RotateRight(head, 0);
            Assert.Equal(new[] { 1, 2, 3 }, ListToArray(result));
        }

        [Fact]
        public void Test_KLessThanLength()
        {
            var sol = new RotateRightSol();
            var head = BuildList(1, 2, 3, 4, 5);
            var result = sol.RotateRight(head, 2);
            Assert.Equal(new[] { 4, 5, 1, 2, 3 }, ListToArray(result));
        }

        [Fact]
        public void Test_KEqualToLength()
        {
            var sol = new RotateRightSol();
            var head = BuildList(1, 2, 3);
            var result = sol.RotateRight(head, 3);
            Assert.Equal(new[] { 1, 2, 3 }, ListToArray(result));
        }

        [Fact]
        public void Test_KGreaterThanLength()
        {
            var sol = new RotateRightSol();
            var head = BuildList(0, 1, 2);
            var result = sol.RotateRight(head, 4);
            Assert.Equal(new[] { 2, 0, 1 }, ListToArray(result));
        }

        [Fact]
        public void Test_NegativeValues()
        {
            var sol = new RotateRightSol();
            var head = BuildList(-1, -2, -3);
            var result = sol.RotateRight(head, 1);
            Assert.Equal(new[] { -3, -1, -2 }, ListToArray(result));
        }

        [Fact]
        public void Test_LargeK()
        {
            var sol = new RotateRightSol();
            var head = BuildList(1, 2, 3, 4, 5);
            var result = sol.RotateRight(head, 2000000000);
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, ListToArray(result));
        }
    }
}
