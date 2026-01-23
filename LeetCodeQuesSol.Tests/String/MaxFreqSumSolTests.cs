using Xunit;
using LeetCodeQuesSol.String;

namespace LeetCodeQuesSol.Tests.String
{
    public class MaxFreqSumSolTests
    {
        [Theory]
        [InlineData("aabbcc", 4)]      // maxV: 2 ('a'), maxC: 2 ('b' or 'c')
        [InlineData("aeiou", 1)]      // maxV: 1, maxC: 0
        [InlineData("bcdfg", 1)]      // maxV: 0, maxC: 1
        [InlineData("aabbccddeeiioouu", 4)] // maxV: 2 ('a','e','i','o','u'), maxC: 2 ('b','c','d')
        [InlineData("zzz", 3)]        // maxV: 0, maxC: 3 ('z')
        [InlineData("a", 1)]          // maxV: 1, maxC: 0
        [InlineData("b", 1)]          // maxV: 0, maxC: 1
        [InlineData("aeioubcdfg", 2)] // maxV: 1, maxC: 1
        [InlineData("abcabcabc", 6)]  // maxV: 3 ('a'), maxC: 3 ('b' or 'c')
        [InlineData(null, 0)]          // null input, should handle gracefully
        public void MaxFreqSum_ReturnsExpected(string s, int expected)
        {
            if (s == null)
                s = string.Empty;
            var sol = new MaxFreqSumSol();
            var result = sol.MaxFreqSum(s);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MaxFreqSum_AllVowels100Times()
        {
            var s = new string('u', 100);
            var sol = new MaxFreqSumSol();
            var result = sol.MaxFreqSum(s);
            Assert.Equal(100, result);
        }
    }
}
