using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol
{
    internal static class MinStartValueSol
    {
        public static int MinStartValue(int[] nums)
        {
            int minSum = 0;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum < minSum)
                {
                    minSum = sum;
                }
            }

            return 1 - minSum > 0 ? 1 - minSum : 1;
        }
    }
}
