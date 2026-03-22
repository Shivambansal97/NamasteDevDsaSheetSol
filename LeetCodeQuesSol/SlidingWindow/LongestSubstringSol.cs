using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.SlidingWindow
{
    /// <summary>
    /// Problem Link: https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    public class LongestSubstringSol
    {
        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> occur = new();
            int maxLen = 0;
            int start = 0;
            int curr = 0;

            while(curr < s.Length)
            {                
                if (!occur.ContainsKey(s[curr])){
                    occur.Add(s[curr], curr);
                    curr++;
                    maxLen = Math.Max(curr - start, maxLen);
                }
                else
                {
                    int currInd = occur[s[curr]];

                    for (int i=start; i <= currInd; i++)
                    {
                        occur.Remove(s[i]);
                    }

                    start = currInd + 1;                    
                }
            }
            
            return maxLen;
            
        }
    }
}
