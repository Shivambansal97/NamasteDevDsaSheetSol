using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Foundation
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/sort-an-array/
    /// </summary>
    internal static class MergeSortSol
    {
        public static int[] SortArray(int[] nums)
        {
            int len = nums.Length;

            if(len == 1)
            {
                return nums;
            }

            int mid = len / 2;


            int[] left = new int[mid];
            int[] right = new int[len - mid];

            Array.Copy(nums, 0, left, 0, mid);
            Array.Copy(nums, mid, right, 0, len - mid);


            left = SortArray(left);
            right = SortArray(right);

            return merge(left, right);
        }

        private static int[] merge(int[] left, int[] right)
        {
            int currLeft = 0;
            int currRight = 0;
            int currInd = 0;

            int[] result = new int[left.Length + right.Length];

            while(currLeft < left.Length && currRight < right.Length)
            {
                if (left[currLeft] <= right[currRight] )
                {
                    result[currInd] = left[currLeft];
                    currLeft++;
                }
                else
                {
                    result[currInd] = right[currRight];
                    currRight++;
                }
                currInd++;
            }
            
            while (currRight < right.Length)
            {
                result[currInd] = right[currRight];
                currInd++;
                currRight++;
            }
            
            while(currLeft < left.Length)
            {
                result[currInd] = left[currLeft];
                currInd++;
                currLeft++;
            }            

            return result;
        }
    }
}
