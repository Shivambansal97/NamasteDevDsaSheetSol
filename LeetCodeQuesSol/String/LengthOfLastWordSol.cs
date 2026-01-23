using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.String
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/length-of-last-word/
    /// </summary>
    public class LengthOfLastWordSol
    {
        public int LengthOfLastWord(string s)
        {
            int length = 0, i = s.Length - 1;
            // Skip trailing spaces
            while (i >= 0 && s[i] == ' ') i--;
            // Count the last word
            while (i >= 0 && s[i] != ' ')
            {
                length++;
                i--;
            }

            return length;
        }
    }
}
