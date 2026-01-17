using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/binary-search/
    /// </summary>
    internal static class BinarySearchSol
    {
        public static int Search(int[] nums, int target)
        {
            int startInd = 0;
            int endInd = nums.Length - 1;

            while (startInd <= endInd)
            {
                int pivot = startInd + (endInd - startInd) / 2;
                if (nums[pivot] == target)
                {
                    return pivot;
                }
                else if (nums[pivot] < target)
                {
                    startInd = pivot + 1;
                }
                else
                {
                    endInd = pivot - 1;
                }
            }

            return -1;
        }
    }
}
