using Xunit;
using LeetCodeQuesSol.String;

namespace LeetCodeQuesSol.Tests.String
{
    public class LargestOddNumSolTests
    {
        [Theory]
        [InlineData("52", "5")]
        [InlineData("4206", "")]
        [InlineData("35427", "35427")]
        [InlineData("13579", "13579")]
        [InlineData("2468", "")]
        [InlineData("1234567890", "123456789")]
        [InlineData("1", "1")]
        [InlineData("2", "")]
        [InlineData("0", "")]
        [InlineData("111111", "111111")]
        [InlineData("222222", "")]
        public void LargestOddNumber_ReturnsExpected(string num, string expected)
        {
            var sol = new LargestOddNumSol();
            var result = sol.LargestOddNumber(num);
            Assert.Equal(expected, result);
        }
    }
}
