using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.String
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/valid-palindrome/
    /// </summary>
    public class ValidPalindromeSol
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();            

            int start = 0;
            int end = s.Length - 1;

            while(start <= end)
            {
                if ((s[start] < 48 || s[start] > 122) || (s[start] < 97 && s[start] > 57) || (s[start] == ' '))
                {
                    start++;
                    continue;
                }
                if ((s[end] < 48 || s[end] > 122) || (s[end] < 97 && s[end] > 57) || (s[end] == ' '))
                {
                    end--;
                    continue;
                }
                if (s[start] != s[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}
