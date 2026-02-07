using System;
using Xunit;
using LeetCodeQuesSol.SlidingWindow;

namespace LeetCodeQuesSol.Tests.SlidingWindow
{
    public class HaystackNeedleSolTests
    {
        [Fact]
        public void HaystackEmpty_NeedleNonEmpty_ReturnsMinusOne()
        {
            var sol = new HaystackNeedleSol();
            Assert.Equal(-1, sol.StrStr("", "a"));
        }

        [Fact]
        public void NeedleAtStart_ReturnsZero()
        {
            var sol = new HaystackNeedleSol();
            Assert.Equal(0, sol.StrStr("hello", "he"));
        }

        [Fact]
        public void NeedleAtEnd_ReturnsThree()
        {
            var sol = new HaystackNeedleSol();
            Assert.Equal(3, sol.StrStr("hello", "lo"));
        }

        [Fact]
        public void NeedleInMiddle_ReturnsTwo()
        {
            var sol = new HaystackNeedleSol();
            Assert.Equal(2, sol.StrStr("abcde", "cd"));
        }

        [Fact]
        public void NeedleNotPresent_ReturnsMinusOne()
        {
            var sol = new HaystackNeedleSol();
            Assert.Equal(-1, sol.StrStr("abcde", "fg"));
        }

        [Fact]
        public void NeedleEqualsHaystack_ReturnsZero()
        {
            var sol = new HaystackNeedleSol();
            Assert.Equal(0, sol.StrStr("abc", "abc"));
        }

        [Fact]
        public void NeedleLongerThanHaystack_ReturnsMinusOne()
        {
            var sol = new HaystackNeedleSol();
            Assert.Equal(-1, sol.StrStr("ab", "abc"));
        }

        [Fact]
        public void TestCaseFromLeetcode1()
        {
            var sol = new HaystackNeedleSol();
            Assert.Equal(4, sol.StrStr("mississippi", "issip"));
        }
    }
}
