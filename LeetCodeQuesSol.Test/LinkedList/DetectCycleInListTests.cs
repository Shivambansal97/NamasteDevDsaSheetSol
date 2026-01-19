using LeetCodeQuesSol.LinkedList;
using Xunit;
using System.Collections.Generic;

namespace LeetCodeQuesSol.Test.LinkedList
{
    public class DetectCycleInListTests
    {
        private ListNode BuildListWithCycle(int[] values, int pos)
        {
            if (values.Length == 0) return null;    
            ListNode dummy = new ListNode(0);
            ListNode curr = dummy;
            ListNode cycleEntry = null;
            for (int i = 0; i < values.Length; i++)
            {
                curr.next = new ListNode(values[i]);
                curr = curr.next;
                if (i == pos) cycleEntry = curr;
            }
            if (pos != -1)
            {
                curr.next = cycleEntry;
            }
            return dummy.next;
        }

        [Fact]
        public void Test_EmptyList()
        {
            var sol = new DetectCycleInList();
            ListNode head = null;
            Assert.False(sol.HasCycle(head));
        }

        [Fact]
        public void Test_SingleNode_NoCycle()
        {
            var sol = new DetectCycleInList();
            var head = new ListNode(1);
            Assert.False(sol.HasCycle(head));
        }

        [Fact]
        public void Test_SingleNode_WithCycle()
        {
            var sol = new DetectCycleInList();
            var head = new ListNode(1);
            head.next = head;
            Assert.True(sol.HasCycle(head));
        }

        [Fact]
        public void Test_MultipleNodes_NoCycle()
        {
            var sol = new DetectCycleInList();
            var head = BuildListWithCycle(new[] { 1, 2, 3, 4, 5 }, -1);
            Assert.False(sol.HasCycle(head));
        }

        [Fact]
        public void Test_MultipleNodes_WithCycle()
        {
            var sol = new DetectCycleInList();
            var head = BuildListWithCycle(new[] { 1, 2, 3, 4, 5 }, 2); // cycle at index 2
            Assert.True(sol.HasCycle(head));
        }

        [Fact]
        public void Test_CycleAtHead()
        {
            var sol = new DetectCycleInList();
            var head = BuildListWithCycle(new[] { 1, 2, 3 }, 0); // cycle at head
            Assert.True(sol.HasCycle(head));
        }
    }
}
