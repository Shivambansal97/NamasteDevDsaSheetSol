using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Arrays
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/max-consecutive-ones/
    /// </summary>
    internal static class MaxConsicutiveOnes
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int count = 0;

            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] == 1)
                {
                    count++;
                }

                else
                {
                    count = 0;
                }

                max = count > max ? count : max;
                
            }

            return max;
        }
    }
}
