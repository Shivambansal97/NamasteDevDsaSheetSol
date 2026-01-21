using LeetCodeQuesSol.LinkedList;
using Xunit;
using System.Collections.Generic;

namespace LeetCodeQuesSol.Test.LinkedList
{
    public class RemoveListNodesTests
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
            var sol = new RemoveListNodes();
            ListNode head = null;
            var result = sol.RemoveElements(head, 1);
            Assert.Null(result);
        }

        [Fact]
        public void Test_SingleNode_Remove()
        {
            var sol = new RemoveListNodes();
            var head = BuildList(5);
            var result = sol.RemoveElements(head, 5);
            Assert.Null(result);
        }

        [Fact]
        public void Test_SingleNode_Keep()
        {
            var sol = new RemoveListNodes();
            var head = BuildList(5);
            var result = sol.RemoveElements(head, 1);
            Assert.Equal(new[] { 5 }, ListToArray(result));
        }

        [Fact]
        public void Test_RemoveMultiple()
        {
            var sol = new RemoveListNodes();
            var head = BuildList(1, 2, 6, 3, 4, 5, 6);
            var result = sol.RemoveElements(head, 6);
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, ListToArray(result));
        }

        [Fact]
        public void Test_RemoveHead()
        {
            var sol = new RemoveListNodes();
            var head = BuildList(7, 7, 7, 7);
            var result = sol.RemoveElements(head, 7);
            Assert.Null(result);
        }

        [Fact]
        public void Test_RemoveTail()
        {
            var sol = new RemoveListNodes();
            var head = BuildList(1, 2, 3, 4, 5);
            var result = sol.RemoveElements(head, 5);
            Assert.Equal(new[] { 1, 2, 3, 4 }, ListToArray(result));
        }

        [Fact]
        public void Test_NoRemoval()
        {
            var sol = new RemoveListNodes();
            var head = BuildList(1, 2, 3, 4, 5);
            var result = sol.RemoveElements(head, 50);
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, ListToArray(result));
        }
    }
}
