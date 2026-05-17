using System;
using System.Collections;
using System.Collections.Generic;
using LeetCodeQuesSol;
using LeetCodeQuesSol.SlidingWindow;
using Xunit;


namespace LeetCodeQuesSol.Tests.SlidingWindow
{
    /// <summary>
    /// Unit tests for <see cref="PermutationsInString"/>.
    /// </summary>
    public class PermutationsInStringTests
    {
        // All tests below use only lowercase English letters and non-empty strings
        // in accordance with the problem constraints: 1 <= s1.length, s2.length <= 10^4

        [Fact]
        public void CheckInclusion_SimplePermutation_ReturnsTrue()
        {
            var solver = new PermutationsInString();
            string s1 = "ab";
            string s2 = "eidbaooo"; // contains "ba"
            Assert.True(solver.CheckInclusion(s1, s2));
        }

        [Fact]
        public void CheckInclusion_NoPermutation_ReturnsFalse()
        {
            var solver = new PermutationsInString();
            string s1 = "ab";
            string s2 = "eidboaoo";
            Assert.False(solver.CheckInclusion(s1, s2));
        }

        [Fact]
        public void CheckInclusion_SameString_ReturnsTrue()
        {
            var solver = new PermutationsInString();
            string s1 = "abc";
            string s2 = "abc";
            Assert.True(solver.CheckInclusion(s1, s2));
        }

        [Fact]
        public void CheckInclusion_S1LongerThanS2_ReturnsFalse()
        {
            var solver = new PermutationsInString();
            string s1 = "abcd";
            string s2 = "abc";
            Assert.False(solver.CheckInclusion(s1, s2));
        }

        [Fact]
        public void CheckInclusion_SingleCharMatch_ReturnsTrue()
        {
            var solver = new PermutationsInString();
            string s1 = "a";
            string s2 = "ba"; // contains 'a'
            Assert.True(solver.CheckInclusion(s1, s2));
        }

        [Fact]
        public void CheckInclusion_RepeatedChars_ReturnsTrue()
        {
            var solver = new PermutationsInString();
            string s1 = "aa";
            string s2 = "aaaa"; // contains permutations of "aa"
            Assert.True(solver.CheckInclusion(s1, s2));
        }

        [Fact]
        public void CheckInclusion_RepeatedChars_NoMatch_ReturnsFalse()
        {
            var solver = new PermutationsInString();
            string s1 = "aa";
            string s2 = "ab"; // only one 'a'
            Assert.False(solver.CheckInclusion(s1, s2));
        }

        [Fact]
        public void CheckInclusion_PermutationAtEnd_ReturnsTrue()
        {
            var solver = new PermutationsInString();
            string s1 = "xyz";
            string s2 = "afxyzbc"; // contains "xyz"
            Assert.True(solver.CheckInclusion(s1, s2));
        }
    }
}