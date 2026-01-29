using Xunit;
using LeetCodeQuesSol.String;

namespace LeetCodeQuesSol.Tests.String
{
    public class LongestCommonPrefixSolTests
    {
        [Theory]
        [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new[] { "dog", "racecar", "car" }, "")]
        [InlineData(new[] { "interspecies", "interstellar", "interstate" }, "inters")]
        [InlineData(new[] { "a" }, "a")]
        [InlineData(new[] { "ab", "a" }, "a")]
        [InlineData(new[] { "prefix", "prefixes", "prefixation" }, "prefix")]
        [InlineData(new[] { "abc", "abc", "abc" }, "abc")]
        [InlineData(new[] { "", "abc" }, "")]
        [InlineData(new[] { "abc", "" }, "")]
        [InlineData(new[] { "" }, "")]
        [InlineData(new[] { "a" , "" }, "")]

        public void LongestCommonPrefix_ReturnsExpected(string[] strs, string expected)
        {
            var sol = new LongestCommonPrefixSol();
            var result = sol.LongestCommonPrefix(strs);
            Assert.Equal(expected, result);
        }
    }
}
