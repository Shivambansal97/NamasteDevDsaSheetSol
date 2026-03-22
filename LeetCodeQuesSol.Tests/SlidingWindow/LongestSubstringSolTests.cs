using System;
using System.Collections;
using System.Collections.Generic;
using LeetCodeQuesSol;
using LeetCodeQuesSol.SlidingWindow;
using Xunit;


namespace LeetCodeQuesSol.Tests.SlidingWindow
{
    /// <summary>
    /// Unit tests for <see cref="LongestSubstringSol"/>.
    /// </summary>
    public class LongestSubstringSolTests
    {
        /// <summary>
        /// Tests LengthOfLongestSubstring with various string inputs, including edge cases:
        /// - Empty string
        /// - Single character
        /// - All unique characters
        /// - All duplicate characters
        /// - Mixed duplicates
        /// - Whitespace, special, and control characters
        /// - Very long string
        /// </summary>
        /// <param name="input">Input string to test.</param>
        /// <param name="expected">Expected length of the longest substring without repeating characters.</param>
        [Theory]
        [InlineData("", 0)] // Empty string
        [InlineData("a", 1)] // Single character
        [InlineData("abcde", 5)] // All unique
        [InlineData("aaaaa", 1)] // All duplicates
        [InlineData("abcabcbb", 3)] // Mixed duplicates
        [InlineData("bbbbb", 1)] // All same
        [InlineData("pwwkew", 3)] // Non-contiguous repeat
        [InlineData("dvdf", 3)] // Overlapping repeats
        [InlineData(" ", 1)] // Single whitespace
        [InlineData("  ", 1)] // Multiple whitespace
        [InlineData("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 62)] // Long unique
        [InlineData("ohvhjdml", 6)] // LeetCode edge
        [InlineData("anviaj", 5)] // LeetCode edge
        [InlineData("a\0b\0c", 3)] // Control character
        [InlineData("abba", 2)] // Palindrome with repeats
        [InlineData("tmmzuxt", 5)] // LeetCode edge
        [InlineData("a!@#b$%^c&*()", 13)] // Special characters
        [InlineData("a b c d", 3)] // Spaces between
        public void LengthOfLongestSubstring_ValidInputs_ReturnsExpected(string input, int expected)
        {
            // Arrange
            var sol = new LongestSubstringSol();

            // Act
            var result = sol.LengthOfLongestSubstring(input);

            // Assert
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Tests LengthOfLongestSubstring with a very long string to ensure no stack/overflow or performance issues.
        /// </summary>
        [Fact]
        public void LengthOfLongestSubstring_VeryLongString_ReturnsExpected()
        {
            // Arrange
            var input = new string('a', 10000);
            var sol = new LongestSubstringSol();

            // Act
            var result = sol.LengthOfLongestSubstring(input);

            // Assert
            Assert.Equal(1, result);
        }

        /// <summary>
        /// Tests LengthOfLongestSubstring with a string containing all possible ASCII characters.
        /// </summary>
        [Fact]
        public void LengthOfLongestSubstring_AllAsciiChars_ReturnsExpected()
        {
            // Arrange
            var chars = new char[128];
            for (int i = 0; i < 128; i++)
                chars[i] = (char)i;
            var input = new string(chars);
            var sol = new LongestSubstringSol();

            // Act
            var result = sol.LengthOfLongestSubstring(input);

            // Assert
            Assert.Equal(128, result);
        }

        /// <summary>
        /// Tests LengthOfLongestSubstring with null input.
        /// Expects ArgumentNullException or similar, depending on implementation.
        /// </summary>
        [Fact]
        public void LengthOfLongestSubstring_NullInput_ThrowsException()
        {
            // Arrange
            var sol = new LongestSubstringSol();

            // Act & Assert
            Assert.ThrowsAny<Exception>(() => sol.LengthOfLongestSubstring(null!));
        }
    }
}