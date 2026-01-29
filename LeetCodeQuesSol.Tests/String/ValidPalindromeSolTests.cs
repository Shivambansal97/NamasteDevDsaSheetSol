using Xunit;
using LeetCodeQuesSol.String;

namespace LeetCodeQuesSol.Tests.String
{
    public class ValidPalindromeSolTests
    {
        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("racecar", true)]
        [InlineData("No lemon, no melon", true)]
        [InlineData("hello", false)]
        [InlineData(" ", true)]
        [InlineData("", true)]
        [InlineData("0P", false)]
        [InlineData("ab@a", true)]
        [InlineData("Able was I, ere I saw Elba", true)]
        [InlineData("Was it a car or a cat I saw?", true)]
        [InlineData("a.", true)]

        public void IsPalindrome_ReturnsExpected(string s, bool expected)
        {
            var sol = new ValidPalindromeSol(); 
            var result = sol.IsPalindrome(s);
            Assert.Equal(expected, result);
        }
    }
}
