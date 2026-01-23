using Xunit;
using LeetCodeQuesSol.String;
using System.Collections.Generic;

namespace LeetCodeQuesSol.Tests.String
{
    public class FindWordsContainingCharTests
    {
        [Theory]
        [InlineData(new[] { "apple", "banana", "cherry" }, 'a', new[] { 0, 1 })]
        [InlineData(new[] { "dog", "cat", "fish" }, 'z', new int[] { })]
        [InlineData(new[] { "a", "b", "c" }, 'a', new[] { 0 })]
        [InlineData(new[] { "abc", "def", "ghi" }, 'i', new[] { 2 })]
        [InlineData(new[] { "abcde" }, 'e', new[] { 0 })]
        [InlineData(new[] { "abc", "abc", "abc" }, 'b', new[] { 0, 1, 2 })]
        [InlineData(new[] { "xyz" }, 'x', new[] { 0 })]
        [InlineData(new[] { "a" }, 'a', new[] { 0 })]
        [InlineData(new[] { "b" }, 'a', new int[] { })]
        [InlineData(new[] { "abcdefghijklmnopqrstuvwxyz" }, 'm', new[] { 0 })]
        public void FindWordsContaining_ReturnsExpected(string[] words, char x, int[] expected)
        {
            var sol = new FindWordsContainingChar();
            var result = sol.FindWordsContaining(words, x);
            Assert.Equal(expected, result);
        }
    }
}
