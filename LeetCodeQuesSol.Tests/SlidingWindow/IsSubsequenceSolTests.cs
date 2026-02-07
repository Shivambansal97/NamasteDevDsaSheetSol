using LeetCodeQuesSol.SlidingWindow;

namespace LeetCodeQuesSol.Tests.SlidingWindow
{
    public class IsSubsequenceSolTests
    {
        [Fact]
        public void BothStringsEmpty_ReturnsTrue()
        {
            Assert.True(IsSubsequenceSol.IsSubsequence("", ""));
        }

        [Fact]
        public void SEmpty_TNonEmpty_ReturnsTrue()
        {
            Assert.True(IsSubsequenceSol.IsSubsequence("", "abc"));
        }

        [Fact]
        public void SNonEmpty_TEmpty_ReturnsFalse()
        {
            Assert.False(IsSubsequenceSol.IsSubsequence("abc", ""));
        }

        [Fact]
        public void SIsSubsequenceOfT_ReturnsTrue()
        {
            Assert.True(IsSubsequenceSol.IsSubsequence("ace", "abcde"));
        }

        [Fact]
        public void SIsNotSubsequenceOfT_ReturnsFalse()
        {
            Assert.False(IsSubsequenceSol.IsSubsequence("aec", "abcde"));
        }

        [Fact]
        public void SEqualsT_ReturnsTrue()
        {
            Assert.True(IsSubsequenceSol.IsSubsequence("abc", "abc"));
        }

        [Fact]
        public void SCharsInTButNotInOrder_ReturnsFalse()
        {
            Assert.False(IsSubsequenceSol.IsSubsequence("cba", "abc"));
        }

        [Fact]
        public void SLongerThanT_ReturnsFalse()
        {
            Assert.False(IsSubsequenceSol.IsSubsequence("abcdef", "abc"));
        }
    }
}
