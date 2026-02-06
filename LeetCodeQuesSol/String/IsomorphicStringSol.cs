using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.String
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/isomorphic-strings/
    /// </summary>
    public class IsomorphicStringSol
    {
        public bool IsIsomorphic(string s, string t)
        {
            var mapST = new Dictionary<char, char>();
            var mapTS = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                char c1 = s[i], c2 = t[i];

                if (mapST.ContainsKey(c1))
                {
                    if (mapST[c1] != c2) return false;
                }
                else
                {
                    if (mapTS.ContainsKey(c2)) return false;
                    mapST[c1] = c2;
                    mapTS[c2] = c1;
                }
            }
            return true;
        }
    }
}
