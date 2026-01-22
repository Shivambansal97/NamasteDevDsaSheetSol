using LeetCodeQuesSol.LinkedList;
using Xunit;
using System.Collections.Generic;

namespace LeetCodeQuesSol.Tests.LinkedList
{
    public class PalindromeListTests
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

        [Fact]
        public void Test_SingleNode()
        {
            var sol = new PalindromeList();
            var head = BuildList(5);
            Assert.True(sol.IsPalindrome(head));
        }

        [Fact]
        public void Test_TwoNodes_Palindrome()
        {
            var sol = new PalindromeList();
            var head = BuildList(7, 7);
            Assert.True(sol.IsPalindrome(head));
        }

        [Fact]
        public void Test_TwoNodes_NotPalindrome()
        {
            var sol = new PalindromeList();
            var head = BuildList(2, 3);
            Assert.False(sol.IsPalindrome(head));
        }

        [Fact]
        public void Test_OddLength_Palindrome()
        {
            var sol = new PalindromeList();
            var head = BuildList(1, 2, 1);
            Assert.True(sol.IsPalindrome(head));
        }

        [Fact]
        public void Test_EvenLength_Palindrome()
        {
            var sol = new PalindromeList();
            var head = BuildList(1, 2, 2, 1);
            Assert.True(sol.IsPalindrome(head));
        }

        [Fact]
        public void Test_NotPalindrome()
        {
            var sol = new PalindromeList();
            var head = BuildList(1, 2, 3, 4);
            Assert.False(sol.IsPalindrome(head));
        }

        [Fact]
        public void Test_LargePalindrome()
        {
            var sol = new PalindromeList();
            int n = 10000;
            var values = new List<int>();
            for (int i = 0; i < n; i++) values.Add(1);
            for (int i = n - 1; i >= 0; i--) values.Add(1);
            var head = BuildList(values.ToArray());
            Assert.True(sol.IsPalindrome(head));
        }

        [Fact]
        public void Test_LargeNotPalindrome()
        {
            var sol = new PalindromeList();
            int n = 10000;
            var values = new List<int>();
            for (int i = 0; i < n; i++) values.Add(1);
            for (int i = n - 1; i >= 0; i--) values.Add(2);
            var head = BuildList(values.ToArray());
            Assert.False(sol.IsPalindrome(head));
        }
    }
}
