using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Arrays
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/single-number/
    /// </summary>
    internal static class SingleNumberSol
    {
        public static int SingleNumber(int[] nums)
        {
            int res = 0;

            foreach(int num in nums)
            {
                res = res ^ num;
            }

            return res;
        }
    }
}
