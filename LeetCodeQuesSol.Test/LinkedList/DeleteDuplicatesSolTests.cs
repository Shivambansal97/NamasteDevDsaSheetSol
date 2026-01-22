using LeetCodeQuesSol.LinkedList;
using Xunit;
using System.Collections.Generic;

namespace LeetCodeQuesSol.Test.LinkedList
{
    public class DeleteDuplicatesSolTests
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
            var sol = new DeleteDuplicatesSol();
            ListNode head = null;
            var result = sol.DeleteDuplicates(head);
            Assert.Null(result);
        }

        [Fact]
        public void Test_SingleNode()
        {
            var sol = new DeleteDuplicatesSol();
            var head = BuildList(1);
            var result = sol.DeleteDuplicates(head);
            Assert.Equal(new[] { 1 }, ListToArray(result));
        }

        [Fact]
        public void Test_NoDuplicates()
        {
            var sol = new DeleteDuplicatesSol();
            var head = BuildList(1, 2, 3, 4, 5);
            var result = sol.DeleteDuplicates(head);
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, ListToArray(result));
        }

        [Fact]
        public void Test_AllDuplicates()
        {
            var sol = new DeleteDuplicatesSol();
            var head = BuildList(2, 2, 2, 2);
            var result = sol.DeleteDuplicates(head);
            Assert.Equal(new[] { 2 }, ListToArray(result));
        }

        [Fact]
        public void Test_MixedDuplicates()
        {
            var sol = new DeleteDuplicatesSol();
            var head = BuildList(1, 1, 2, 3, 3, 4, 4, 4, 5);
            var result = sol.DeleteDuplicates(head);
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, ListToArray(result));
        }

        [Fact]
        public void Test_DuplicatesAtEnd()
        {
            var sol = new DeleteDuplicatesSol();
            var head = BuildList(1, 2, 3, 4, 4, 4);
            var result = sol.DeleteDuplicates(head);
            Assert.Equal(new[] { 1, 2, 3, 4 }, ListToArray(result));
        }
    }
}
