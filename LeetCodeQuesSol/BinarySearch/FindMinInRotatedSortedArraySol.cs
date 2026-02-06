using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.BinarySearch
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
    /// </summary>
    public static class FindMinInRotatedSortedArraySol
    {
        public static int FindMin(int[] arr)
        {
            int high = arr.Length -1;

            int low = 0;

            if (arr[low] <= arr[high])
            {
                //array has no rotation
                return arr[low];
            }

            while(low <= high)
            {                
                int mid = (low + high) / 2;

                if (mid > 0 && arr[mid] <= arr[mid - 1])
                {
                    return arr[mid];
                }

                if (arr[mid] < arr[high])
                {
                    high = mid - 1;  // min is in left side
                }
                else
                {
                    low = mid + 1; // min is in right side
                }
            }

            return -1;
        }
    }
}
