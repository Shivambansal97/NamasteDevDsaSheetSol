using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.SlidingWindow
{
    /// <summary>
    /// Problem Link: https://leetcode.com/problems/longest-repeating-character-replacement/
    /// </summary>
    public class LongestRepeatingChar
    {
        public int CharacterReplacement(string s, int k)
        {
            int maxLength = 0;
            int maxFreq = 0; //max occurance of char -> (AAAB -> 3)
            int[] freq = new int[26];

            int left = 0, right = 0;

            while(right < s.Length)
            {
                freq[s[right] - 'A']++;
                maxFreq = Math.Max(maxFreq, freq[s[right] - 'A']);

                int change = (right - left + 1) - maxFreq;

                if(change <= k)
                {
                    maxLength = Math.Max(maxLength, right - left + 1);
                }
                else
                {
                    freq[s[left]-'A']--;
                    left++;
                }
                right++;
            }
            return maxLength;
        }
    }
}
