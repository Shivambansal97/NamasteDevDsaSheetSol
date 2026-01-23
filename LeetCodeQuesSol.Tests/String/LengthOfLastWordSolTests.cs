using Xunit;
using LeetCodeQuesSol.String;

namespace LeetCodeQuesSol.Tests.String
{
    public class LengthOfLastWordSolTests
    {
        [Theory]
        [InlineData("Hello World", 5)]
        [InlineData("   fly me   to   the moon  ", 4)]
        [InlineData("luffy is still joyboy", 6)]
        [InlineData("a", 1)]
        [InlineData("a ", 1)]
        [InlineData(" ", 0)]
        [InlineData("", 0)]
        [InlineData("word", 4)]
        [InlineData("word ", 4)]
        [InlineData("multiple   spaces   ", 6)]
        public void LengthOfLastWord_ReturnsExpected(string input, int expected)
        {
            var sol = new LengthOfLastWordSol();
            var result = sol.LengthOfLastWord(input);
            Assert.Equal(expected, result);
        }
    }
}
