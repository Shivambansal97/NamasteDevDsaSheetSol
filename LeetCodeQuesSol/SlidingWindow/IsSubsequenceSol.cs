using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.SlidingWindow
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/is-subsequence/
    /// </summary>
    public static class IsSubsequenceSol
    {
        public static bool IsSubsequence(string s, string t)
        {
            int i = 0, j = 0;

            while (j < t.Length && i < s.Length )
            {
                if (s[i] == t[j])
                {
                    i++;
                }
                j++;
            }

            if(i >= s.Length)
            {
                return true;
            }

            return false;
        }
    }
}
