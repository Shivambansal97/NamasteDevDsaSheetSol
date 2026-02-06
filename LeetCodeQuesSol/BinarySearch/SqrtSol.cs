using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.BinarySearch
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/sqrtx/
    /// </summary>
    public static class SqrtSol
    {
        public static int MySqrt(int x)
        {
            if(x == 0)
            {
                return 0;
            }

            int high = x;
            int low = 1;
            int ans = 0;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if ((long)mid * mid == x)
                {
                    return mid;
                }
                else if ((long)mid * mid > x)
                {
                    high = mid-1;
                }
                else
                {
                    ans = mid;
                    low = mid+1;
                }
            }

            return ans;
        }
    }
}
