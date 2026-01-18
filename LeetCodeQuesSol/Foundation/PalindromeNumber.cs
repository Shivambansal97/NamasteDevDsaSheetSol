using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Foundation
{
    /// <summary>
    /// problem link: https://leetcode.com/problems/palindrome-number/
    /// </summary>
    internal static class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            int reversedHalf = 0;
            while (x > reversedHalf)
            {
                reversedHalf = reversedHalf * 10 + x % 10;
                x /= 10;
            }

            return x == reversedHalf || x == reversedHalf / 10;
        }
    }
}
