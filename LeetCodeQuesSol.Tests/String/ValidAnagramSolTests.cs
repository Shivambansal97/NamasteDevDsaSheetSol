using LeetCodeQuesSol.String;
using Xunit;

namespace LeetCodeQuesSol.Tests.String
{
    public class ValidAnagramSolTests
    {
        [Theory]
        [InlineData("anagram", "nagaram", true)]
        [InlineData("rat", "car", false)]
        [InlineData("a", "a", true)]
        [InlineData("a", "b", false)]
        [InlineData("ab", "ba", true)]
        [InlineData("abc", "cba", true)]
        [InlineData("abc", "ab", false)]
        [InlineData("aabbcc", "baccab", true)]
        [InlineData("aabbcc", "aabbc", false)]
        [InlineData("", "", true)]
        public void IsAnagram_ReturnsExpected(string s, string t, bool expected)
        {
            var sol = new ValidAnagramSol();
            var result = sol.IsAnagram(s, t);
            Assert.Equal(expected, result);
        }
    }
}
