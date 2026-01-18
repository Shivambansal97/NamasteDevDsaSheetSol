using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Arrays
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/move-zeroes/
    /// </summary>
    internal static class MoveZerosSol
    {
        public static void MoveZeroes(int[] nums)
        {
            int lastNonZeroFoundAt = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    // Swap only if i != lastNonZeroFoundAt to avoid unnecessary swaps
                    if (i != lastNonZeroFoundAt)
                    {
                        int temp = nums[lastNonZeroFoundAt];
                        nums[lastNonZeroFoundAt] = nums[i];
                        nums[i] = temp;
                    }
                    lastNonZeroFoundAt++;
                }
            }
        }

        //public static void MoveZeroes(int[] nums)
        //{
        //    int i = 0;
        //    int j = 1;

        //    while(i < nums.Length && j < nums.Length)
        //    {
        //        if (nums[i] == 0) 
        //        {
        //            if (nums[j] != 0)
        //            {
        //                //swap
        //                int temp = nums[i];
        //                nums[i] = nums[j];
        //                nums[j] = temp;
        //                i++;
        //            }
        //        }
        //        else
        //        {
        //            i++;
        //        }
        //        j++;
        //    }
        //}
    }
}
