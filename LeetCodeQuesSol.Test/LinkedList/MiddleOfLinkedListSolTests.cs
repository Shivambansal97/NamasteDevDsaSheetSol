using LeetCodeQuesSol.LinkedList;
using Xunit;
using System.Collections.Generic;

namespace LeetCodeQuesSol.Tests.LinkedList
{
    public class MiddleOfLinkedListSolTests
    {
        private ListNode? BuildList(params int[] values)
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

        private int[] ListToArray(ListNode? node)
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
        public void Test_OddLengthList()
        {
            var sol = new MiddleOfLinkedListSol();
            var head = BuildList(1, 2, 3, 4, 5);
            var middle = sol.MiddleNode(head);
            Assert.Equal(3, middle.val);
            Assert.Equal(new[] { 3, 4, 5 }, ListToArray(middle));
        }

        [Fact]
        public void Test_EvenLengthList()
        {
            var sol = new MiddleOfLinkedListSol();
            var head = BuildList(1, 2, 3, 4, 5, 6);
            var middle = sol.MiddleNode(head);
            Assert.Equal(4, middle.val);
            Assert.Equal(new[] { 4, 5, 6 }, ListToArray(middle));
        }

        [Fact]
        public void Test_SingleElementList()
        {
            var sol = new MiddleOfLinkedListSol();
            var head = BuildList(42);
            var middle = sol.MiddleNode(head);
            Assert.Equal(42, middle.val);
            Assert.Equal(new[] { 42 }, ListToArray(middle));
        }

        [Fact]
        public void Test_TwoElementList()
        {
            var sol = new MiddleOfLinkedListSol();
            var head = BuildList(7, 8);
            var middle = sol.MiddleNode(head);
            Assert.Equal(8, middle.val);
            Assert.Equal(new[] { 8 }, ListToArray(middle));
        }
        
    }
}
