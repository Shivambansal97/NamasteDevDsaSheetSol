using System;
using LeetCodeQuesSol.SlidingWindow;
using Xunit;

namespace LeetCodeQuesSol.Tests.SlidingWindow
{
    /// <summary>
    /// Unit tests for <see cref="LongestRepeatingChar"/>.
    /// Problem: Find the longest substring with at most k character replacements to make all characters the same.
    /// Problem Link: https://leetcode.com/problems/longest-repeating-character-replacement/
    /// </summary>
    public class LongestRepeatingCharTests
    {
        /// <summary>
        /// Tests CharacterReplacement with various string inputs and k values, including edge cases:
        /// - Empty string
        /// - Single character
        /// - k = 0 (no replacements allowed)
        /// - k > string length
        /// - All same characters
        /// - All different characters
        /// - Mixed patterns
        /// </summary>
        /// <param name="input">Input string to test.</param>
        /// <param name="k">Maximum number of character replacements allowed.</param>
        /// <param name="expected">Expected length of the longest substring with k replacements.</param>
        [Theory]
        [InlineData("ABAB", 2, 4)] // Replace all Bs with A (or all As with B)
        [InlineData("ABBB", 2, 4)] // Replace 2 As with B
        [InlineData("AAAA", 0, 4)] // No replacements needed
        [InlineData("AAAA", 2, 4)] // All same character
        [InlineData("A", 0, 1)] // Single character, k=0
        [InlineData("A", 5, 1)] // Single character, k > length
        [InlineData("", 0, 0)] // Empty string
        [InlineData("ABCDE", 1, 2)] // All different, only consecutive pairs
        [InlineData("AABBCC", 2, 4)] // Mixed blocks, e.g., "AAAA" or "BBBB"
        [InlineData("BAAACBD", 2, 5)] // "AAAAA" by replacing BC with A
        [InlineData("ABABAB", 2, 5)] // Alternating pattern
        [InlineData("ABCABCABCABCABCABCAB", 5, 8)] // Longer alternating pattern
        [InlineData("AAAAAB", 0, 5)] // k=0 with mostly same character
        [InlineData("AAAAAB", 1, 6)] // k=1 replaces B with A
        [InlineData("ZZZZZZZZZ", 3, 9)] // All same, high k value
        [InlineData("AAABBBCCC", 2, 5)] // e.g., "AAAAAA" or "BBBBBB"
        [InlineData("ABCDEFGHIJ", 0, 1)] // All unique, no replacements
        [InlineData("ABCDEFGHIJ", 9, 10)] // All unique, k covers all
        [InlineData("A", 1, 1)] // Single character with k
        [InlineData("AB", 1, 2)] // Two different characters
        [InlineData("AAABBBCCC", 3, 6)] // All three blocks can be replaced to one
        [InlineData("AABBBCD", 2, 5)] // "BBBBB" by replacing A and C with B
        public void CharacterReplacement_ValidInputs_ReturnsExpected(string s, int k, int expected)
        {
            // Arrange
            var sol = new LongestRepeatingChar();

            // Act
            int result = sol.CharacterReplacement(s, k);

            // Assert
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Tests CharacterReplacement with edge case where k is greater than string length.
        /// The entire string should be returnable since we can replace anything.
        /// </summary>
        [Fact]
        public void CharacterReplacement_KGreaterThanStringLength_ReturnsFullLength()
        {
            // Arrange
            var sol = new LongestRepeatingChar();
            string s = "ABCDE";
            int k = 100;

            // Act
            int result = sol.CharacterReplacement(s, k);

            // Assert
            Assert.Equal(s.Length, result);
        }

        /// <summary>
        /// Tests CharacterReplacement with large input string.
        /// </summary>
        [Fact]
        public void CharacterReplacement_LargeInput_PerformsEfficiently()
        {
            // Arrange
            var sol = new LongestRepeatingChar();
            string s = new string('A', 1000) + new string('B', 1000);
            int k = 500;

            // Act
            int result = sol.CharacterReplacement(s, k);

            // Assert - Should be able to replace 500 Bs, making 1000 + 500 = 1500 As
            Assert.Equal(1500, result);
        }

        /// <summary>
        /// Tests CharacterReplacement with k = 0 (no replacements allowed).
        /// Should return the longest consecutive sequence of the same character.
        /// </summary>
        [Fact]
        public void CharacterReplacement_NoReplacements_ReturnsLongestConsecutiveSame()
        {
            // Arrange
            var sol = new LongestRepeatingChar();
            string s = "AABBAABBAA";
            int k = 0;

            // Act
            int result = sol.CharacterReplacement(s, k);

            // Assert - Longest is "AA" or "BB"
            Assert.Equal(2, result);
        }
    }
}
