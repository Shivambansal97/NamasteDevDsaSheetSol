using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Greedy
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/assign-cookies/
    /// </summary>
    public static class AssignCookies
    {
        public static int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            int i = 0, j = 0;

            int result = 0;

            while(i < g.Length && j < s.Length)
            {
                if (g[i] <= s[j])
                {
                    result++;
                    i++;
                }
                j++;
            }

            return result;
        }
    }
}
