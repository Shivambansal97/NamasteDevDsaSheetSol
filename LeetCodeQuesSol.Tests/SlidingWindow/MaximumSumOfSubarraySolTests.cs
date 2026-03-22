using System;
using Xunit;
using LeetCodeQuesSol.SlidingWindow;

namespace LeetCodeQuesSol.Tests.SlidingWindow
{
    public class MaximumSumOfSubarraySolTests
    {
        [Fact]
        public void BasicCase()
        {
            var sol = new MaximumSumOfSubarraySol();
            Assert.Equal(9, sol.MaximumSubarraySum(new[] {1, 2, 3, 4, 5}, 2));
        }
        

        [Fact]
        public void AllPositiveNumbers()
        {
            var sol = new MaximumSumOfSubarraySol();
            Assert.Equal(12, sol.MaximumSubarraySum(new[] {1, 2, 3, 4, 5}, 3));
        }

        [Fact]
        public void KIsOne()
        {
            var sol = new MaximumSumOfSubarraySol();
            Assert.Equal(5, sol.MaximumSubarraySum(new[] {1, 2, 3, 4, 5}, 1));
        }

        [Fact]
        public void KIsArrayLength()
        {
            var sol = new MaximumSumOfSubarraySol();
            Assert.Equal(15, sol.MaximumSubarraySum(new[] {1, 2, 3, 4, 5}, 5));
        }        

        [Fact]
        public void ArrayWithZeros()
        {
            var sol = new MaximumSumOfSubarraySol();
            Assert.Equal(3, sol.MaximumSubarraySum(new[] {0, 0, 0, 1, 2}, 2));
        }

        [Fact]
        public void MixedValues()
        {
            var sol = new MaximumSumOfSubarraySol();
            Assert.Equal(7, sol.MaximumSubarraySum(new[] {4, 1, 2, 1}, 3));
        }

        [Fact]
        public void AllElementsInSubarrayMustBeDistinct()
        {
            var sol = new MaximumSumOfSubarraySol();
            // Only subarrays [1,2,3] and [2,3,4] are valid for k=3
            Assert.Equal(68, sol.MaximumSubarraySum(new[] { 9, 18, 10, 13, 17, 9, 19, 2, 1, 18 }, 5));
        }
    }
}
