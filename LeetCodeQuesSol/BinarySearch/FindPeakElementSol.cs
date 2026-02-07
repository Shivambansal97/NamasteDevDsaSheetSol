using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.BinarySearch
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/find-peak-element/
    /// </summary>
    public static class FindPeakElementSol
    {
        public static int FindPeakElement(int[] nums)
        {
            int low = 0;
            int high = nums.Length - 1;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] > nums[mid + 1])
                    high = mid;
                else
                    low = mid + 1;
            }
            return low;
        }
    }
}
