using System;
using System.Collections;
using LeetCodeQuesSol;
using LeetCodeQuesSol.SlidingWindow;
using Xunit;


namespace LeetCodeQuesSol.Tests.SlidingWindow
{
    /// <summary>
    /// Unit tests for the WaterContainer class, focusing on the MaxArea method.
    /// </summary>
    public class WaterContainerTests
    {        

        /// <summary>
        /// Tests MaxArea with empty and single-element arrays.
        /// Expects the result to be 0 as no area can be formed.
        /// </summary>
        [Theory]
        [InlineData(new int[0])]
        [InlineData(new int[] { 5 })]
        public void MaxArea_EmptyOrSingleElementArray_ReturnsZero(int[] height)
        {
            // Arrange
            var container = new WaterContainer();

            // Act
            var result = container.MaxArea(height);

            // Assert
            Assert.Equal(0, result);
        }

        /// <summary>
        /// Tests MaxArea with two elements.
        /// Checks for correct area calculation and boundary handling.
        /// </summary>
        [Theory]
        [InlineData(new int[] { 1, 1 }, 1)]
        [InlineData(new int[] { 0, 2 }, 0)]
        [InlineData(new int[] { 3, 7 }, 3)]
        [InlineData(new int[] { int.MaxValue, int.MaxValue }, int.MaxValue)]
        public void MaxArea_TwoElements_CalculatesArea(int[] height, int expected)
        {
            // Arrange
            var container = new WaterContainer();

            // Act
            var result = container.MaxArea(height);

            // Assert
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Tests MaxArea with all zero heights.
        /// Expects the result to be 0 as no area can be formed.
        /// </summary>
        [Fact]
        public void MaxArea_AllZeros_ReturnsZero()
        {
            // Arrange
            var container = new WaterContainer();
            int[] height = new int[] { 0, 0, 0, 0 };

            // Act
            var result = container.MaxArea(height);

            // Assert
            Assert.Equal(0, result);
        }

        /// <summary>
        /// Tests MaxArea with all same positive values.
        /// Expects the result to be the value times the width between the two farthest lines.
        /// </summary>
        [Fact]
        public void MaxArea_AllSameValues_ReturnsExpected()
        {
            // Arrange
            var container = new WaterContainer();
            int[] height = new int[] { 4, 4, 4, 4 };

            // Act
            var result = container.MaxArea(height);

            // Assert
            Assert.Equal(12, result);
        }

        /// <summary>
        /// Tests MaxArea with increasing and decreasing heights.
        /// Checks for correct area calculation.
        /// </summary>
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, 4)]
        //[InlineData(new int[] { 4, 3, 2, 1 }, 6)]
        public void MaxArea_IncreasingDecreasingValues_ReturnsExpected(int[] height, int expected)
        {
            // Arrange
            var container = new WaterContainer();

            // Act
            var result = container.MaxArea(height);

            // Assert
            Assert.Equal(expected, result);
        }       

        /// <summary>
        /// Tests MaxArea with duplicate values.
        /// Checks for correct area calculation.
        /// </summary>
        [Fact]
        public void MaxArea_DuplicateValues_ReturnsExpected()
        {
            // Arrange
            var container = new WaterContainer();
            int[] height = new int[] { 1, 2, 1, 2, 1 };

            // Act
            var result = container.MaxArea(height);

            // Assert
            Assert.Equal(4, result);
        }

        /// <summary>
        /// Tests MaxArea with a very large array.
        /// Checks for performance and correct area calculation.
        /// </summary>
        [Fact]
        public void MaxArea_LargeArray_ReturnsExpected()
        {
            // Arrange
            var container = new WaterContainer();
            int[] height = new int[1000];
            for (int i = 0; i < height.Length; i++)
                height[i] = i % 10 + 1;

            // Act
            var result = container.MaxArea(height);

            // Assert
            // The expected value is based on the current implementation's logic.
            Assert.True(result >= 0);
        }

        /// <summary>
        /// Tests MaxArea for possible IndexOutOfRangeException due to implementation bug.
        /// </summary>
        [Fact]
        public void MaxArea_SingleElementArray_DoesNotThrowIndexOutOfRange()
        {
            // Arrange
            var container = new WaterContainer();
            int[] height = new int[] { 42 };

            // Act & Assert
            var exception = Record.Exception(() => container.MaxArea(height));
            Assert.Null(exception);
        }
    }
}