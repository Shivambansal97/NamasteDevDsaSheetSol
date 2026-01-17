using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/reverse-integer/
    /// </summary>
    internal static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            int reversed = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                // Check for overflow before multiplying and adding
                if (reversed > int.MaxValue / 10 || (reversed == int.MaxValue / 10 && pop > 7))
                    return 0;
                if (reversed < int.MinValue / 10 || (reversed == int.MinValue / 10 && pop < -8))
                    return 0;
                reversed = reversed * 10 + pop;
            }
            return reversed;
        }
    }
}
