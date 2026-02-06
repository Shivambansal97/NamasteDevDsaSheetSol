using Xunit;
using LeetCodeQuesSol.String;

namespace LeetCodeQuesSol.Tests.String
{
    public class IsomorphicStringSolTests
    {
        [Theory]
        [InlineData("egg", "add", true)]
        [InlineData("foo", "bar", false)]
        [InlineData("paper", "title", true)]
        [InlineData("ab", "aa", false)]
        [InlineData("a", "a", true)]
        [InlineData("abc", "def", true)]
        [InlineData("abc", "dee", false)]
        [InlineData("abcd", "aabb", false)]
        [InlineData("!@#", "$%^", true)]
        [InlineData("123", "321", true)]
        [InlineData("abca", "zbxz", true)]
        [InlineData("abca", "zbxy", false)]
        public void IsIsomorphic_ReturnsExpected(string s, string t, bool expected)
        {
            var sol = new IsomorphicStringSol();
            var result = sol.IsIsomorphic(s, t);
            Assert.Equal(expected, result);
        }
    }
}
