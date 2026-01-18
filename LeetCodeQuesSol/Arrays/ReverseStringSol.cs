using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Arrays
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/reverse-string/
    /// </summary>
    internal static class ReverseStringSol
    {
        public static void ReverseString(char[] s)
        {
            int curr = 0;
            int last = s.Length - 1;

            if (last < 0)
            {
                return;
            }

            while (curr < last)
            {
                char temp = s[curr];
                s[curr] = s[last];
                s[last] = temp;

                //(s[curr], s[last]) = (s[last], s[curr]);

                //s[curr] = (char)(s[curr] + s[last]);
                //s[last] = (char)(s[curr] - s[last]);
                //s[curr] = (char)(s[curr] - s[last]);

                curr++;
                last--;
            }
        }        
    }
}
