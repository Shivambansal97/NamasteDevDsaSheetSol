using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.BinarySearch
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    /// </summary>
    public static class FirstAndLastPosSol
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0) return [-1, -1];

            int low = 0, high = nums.Length - 1;

            while(low <= high)
            {
                 int mid = (low + high) / 2;

                if (nums[mid] == target)
                {
                    if (nums[low] == nums[high] && nums[low] == target)
                    {
                        return [low,high];
                    }
                    if (nums[low] != target)
                    {
                        low++;
                    }
                    if (nums[high] != target)
                    {
                        high--;
                    }
                }
                else if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return [-1, -1];
        }
    }
}
