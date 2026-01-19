using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Arrays
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/merge-sorted-array/
    /// </summary>
    internal static class MergeSortedArraySol
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int currLeft = m - 1;
            int currRight = n - 1;
            int currInd = m + n - 1;

            while (currLeft >= 0 && currRight >= 0)
            {
                if (nums1[currLeft] >= nums2[currRight])
                {
                    nums1[currInd] = nums1[currLeft];
                    currLeft--;
                }
                else
                {
                    nums1[currInd] = nums2[currRight];
                    currRight--;
                }
                currInd--;
            }

            while (currRight >= 0)
            {
                nums1[currInd] = nums2[currRight];
                currInd--;
                currRight--;
            }
            
        }
    }
}
