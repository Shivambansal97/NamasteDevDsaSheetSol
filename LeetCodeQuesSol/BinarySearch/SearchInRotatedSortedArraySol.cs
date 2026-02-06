using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.BinarySearch
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/search-in-rotated-sorted-array/
    /// </summary>
    public static class SearchInRotatedSortedArraySol
    {
        public static int Search(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] == target) return mid;

                // Left side is sorted
                if (nums[low] <= nums[mid])
                {
                    if (nums[low] <= target && target < nums[mid])
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                // Right side is sorted
                else
                {
                    if (nums[mid] < target && target <= nums[high])
                        low = mid + 1;
                    else
                        high = mid - 1;
                }
            }
            return -1;
        }
    }
}
