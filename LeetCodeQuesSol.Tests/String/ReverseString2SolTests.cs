using Xunit;
using LeetCodeQuesSol.String;

namespace LeetCodeQuesSol.Tests.String
{
    public class ReverseString2SolTests
    {
        [Theory]
        [InlineData("abcdefg", 2, "bacdfeg")]
        [InlineData("abcd", 2, "bacd")]
        [InlineData("a", 2, "a")]
        [InlineData("abcdefg", 3, "cbadefg")]
        [InlineData("abcdefg", 1, "abcdefg")]
        [InlineData("abcdefgh", 2, "bacdfegh")]
        [InlineData("abcdefgh", 3, "cbadefhg")]
        [InlineData("abcdefgh", 4, "dcbaefgh")]
        [InlineData("abcdefgh", 8, "hgfedcba")]
        [InlineData("abcdefgh", 10, "hgfedcba")]
        public void ReverseStr_ReturnsExpected(string s, int k, string expected)
        {
            var sol = new ReverseString2Sol();
            var result = sol.ReverseStr(s, k);
            Assert.Equal(expected, result);
        }
    }
}
