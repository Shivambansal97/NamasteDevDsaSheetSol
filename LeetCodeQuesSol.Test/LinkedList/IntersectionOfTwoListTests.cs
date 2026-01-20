using LeetCodeQuesSol.LinkedList;
using Xunit;

namespace LeetCodeQuesSol.Test.LinkedList
{
    public class IntersectionOfTwoListTests
    {
        // Helper to build two lists with intersection
        private (ListNode, ListNode, ListNode) BuildListsWithIntersection(
            int[] listA, int[] listB, int[] intersection, int skipA, int skipB)
        {
            ListNode dummyA = new ListNode(0), dummyB = new ListNode(0), intersect = null;
            ListNode currA = dummyA, currB = dummyB;

            for (int i = 0; i < skipA; i++)
            {
                currA.next = new ListNode(listA[i]);
                currA = currA.next;
            }
            for (int i = 0; i < skipB; i++)
            {
                currB.next = new ListNode(listB[i]);
                currB = currB.next;
            }
            // Build intersection
            ListNode intersectDummy = new ListNode(0);
            ListNode currIntersect = intersectDummy;
            foreach (var v in intersection)
            {
                currIntersect.next = new ListNode(v);
                currIntersect = currIntersect.next;
            }
            intersect = intersectDummy.next;
            currA.next = intersect;
            currB.next = intersect;

            return (dummyA.next, dummyB.next, intersect);
        }

        // Helper to build two lists with no intersection
        private (ListNode, ListNode) BuildListsNoIntersection(int[] listA, int[] listB)
        {
            ListNode dummyA = new ListNode(0), dummyB = new ListNode(0);
            ListNode currA = dummyA, currB = dummyB;
            foreach (var v in listA)
            {
                currA.next = new ListNode(v);
                currA = currA.next;
            }
            foreach (var v in listB)
            {
                currB.next = new ListNode(v);
                currB = currB.next;
            }
            return (dummyA.next, dummyB.next);
        }

        [Fact]
        public void Test_Intersection_Exists()
        {
            var sol = new IntersectionOfTwoList();
            // listA: 1->2->3, listB: 4->5, intersection: 6->7
            var (headA, headB, intersect) = BuildListsWithIntersection(
                new[] { 1, 2, 3 }, new[] { 4, 5 }, new[] { 6, 7 }, 3, 2);
            var result = sol.GetIntersectionNode(headA, headB);
            Assert.Equal(intersect, result);
        }

        [Fact]
        public void Test_NoIntersection()
        {
            var sol = new IntersectionOfTwoList();
            var (headA, headB) = BuildListsNoIntersection(new[] { 1, 2, 3 }, new[] { 4, 5, 6 });
            var result = sol.GetIntersectionNode(headA, headB);
            Assert.Null(result);
        }

        [Fact]
        public void Test_Intersection_AtHead()
        {
            var sol = new IntersectionOfTwoList();
            // Both lists are the same
            var intersect = new ListNode(10);
            var result = sol.GetIntersectionNode(intersect, intersect);
            Assert.Equal(intersect, result);
        }

        [Fact]
        public void Test_Intersection_AtTail()
        {
            var sol = new IntersectionOfTwoList();
            var tail = new ListNode(99);
            var headA = new ListNode(1, new ListNode(2, tail));
            var headB = new ListNode(3, tail);
            var result = sol.GetIntersectionNode(headA, headB);
            Assert.Equal(tail, result);
        }

        [Fact]
        public void Test_SingleNode_NoIntersection()
        {
            var sol = new IntersectionOfTwoList();
            var headA = new ListNode(1);
            var headB = new ListNode(2);
            var result = sol.GetIntersectionNode(headA, headB);
            Assert.Null(result);
        }
    }
}
