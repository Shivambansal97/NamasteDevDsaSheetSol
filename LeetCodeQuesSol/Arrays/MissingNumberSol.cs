using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Arrays
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/missing-number/
    /// </summary>
    internal static class MissingNumberSol
    {
        public static int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;
            foreach (int num in nums)
            {
                actualSum += num;
            }
            return expectedSum - actualSum;

        }
    }
}
