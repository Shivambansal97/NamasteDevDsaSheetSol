using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.String
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/valid-anagram/
    /// </summary>
    public class ValidAnagramSol
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> count = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (count.ContainsKey(s[i]))
                    count[s[i]]++;
                else
                    count[s[i]] = 1;

                if (count.ContainsKey(t[i]))
                    count[t[i]]--;
                else
                    count[t[i]] = -1;
            }

            foreach (var kvp in count)
            {
                if (kvp.Value != 0)
                    return false;
            }
            return true;
        }
    }
}
