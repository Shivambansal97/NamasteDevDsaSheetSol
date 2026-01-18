using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Foundation
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/power-of-two/
    /// </summary>
    internal static class PowerOfTwoSol
    {
        public static bool IsPowerOfTwo(int n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
