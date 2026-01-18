using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Arrays
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// </summary>
    internal static class RemoveDuplicatesSol
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int curr = 1;
            int result = 0;

            while(curr < nums.Length)
            {
                if (nums[curr] != nums[curr - 1])
                {
                    nums[result] = nums[curr - 1];
                    result++;
                }
                curr++;                
            }

            nums[result] = nums[curr - 1];
            result++;            

            return result;
        }
    }
}
