using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Arrays
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/remove-element/
    /// </summary>
    internal static class RemoveElementSol
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int write = 0;
            for (int read = 0; read < nums.Length; read++)
            {
                if (nums[read] != val)
                {
                    nums[write] = nums[read];
                    write++;
                }
            }
            return write;
        }
    }
}
