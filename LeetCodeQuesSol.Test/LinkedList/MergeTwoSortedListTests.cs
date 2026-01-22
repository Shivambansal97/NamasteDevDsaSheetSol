using LeetCodeQuesSol.LinkedList;
using Xunit;
using System.Collections.Generic;

namespace LeetCodeQuesSol.Tests.LinkedList
{
    public class MergeTwoSortedListTests
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
        public void Test_BothEmpty()
        {
            var sol = new MergeTwoSortedList();
            ListNode l1 = null, l2 = null;
            var result = sol.MergeTwoLists(l1, l2);
            Assert.Null(result);
        }

        [Fact]
        public void Test_OneEmpty()
        {
            var sol = new MergeTwoSortedList();
            var l1 = BuildList(1, 2, 3);
            ListNode l2 = null;
            var result = sol.MergeTwoLists(l1, l2);
            Assert.Equal(new[] { 1, 2, 3 }, ListToArray(result));
        }

        [Fact]
        public void Test_SingleNodeEach()
        {
            var sol = new MergeTwoSortedList();
            var l1 = BuildList(-1);
            var l2 = BuildList(2);
            var result = sol.MergeTwoLists(l1, l2);
            Assert.Equal(new[] { -1, 2 }, ListToArray(result));
        }

        [Fact]
        public void Test_MixedValues()
        {
            var sol = new MergeTwoSortedList();
            var l1 = BuildList(-3, 0, 2, 5);
            var l2 = BuildList(-2, 1, 3, 4);
            var result = sol.MergeTwoLists(l1, l2);
            Assert.Equal(new[] { -3, -2, 0, 1, 2, 3, 4, 5 }, ListToArray(result));
        }

        [Fact]
        public void Test_DuplicateValues()
        {
            var sol = new MergeTwoSortedList();
            var l1 = BuildList(1, 3, 5);
            var l2 = BuildList(1, 3, 5);
            var result = sol.MergeTwoLists(l1, l2);
            Assert.Equal(new[] { 1, 1, 3, 3, 5, 5 }, ListToArray(result));
        }

        [Fact]
        public void Test_Interleaved()
        {
            var sol = new MergeTwoSortedList();
            var l1 = BuildList(1, 4, 6);
            var l2 = BuildList(2, 3, 5);
            var result = sol.MergeTwoLists(l1, l2);
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6 }, ListToArray(result));
        }
    }
}
