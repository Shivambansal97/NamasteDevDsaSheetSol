using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.String
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/maximum-frequency-sum-of-vowels-and-consonants/
    /// </summary>
    public class MaxFreqSumSol
    {
        public int MaxFreqSum(string s)
        {
            int[] freq = new int[26];
            int maxV = 0, maxC = 0;
            HashSet<char> vowels = new() { 'a', 'e', 'i', 'o', 'u' };

            foreach (char c in s)
            {
                int idx = c - 'a';
                freq[idx]++;
                if (vowels.Contains(c))
                {
                    if (freq[idx] > maxV) maxV = freq[idx];
                }
                else
                {
                    if (freq[idx] > maxC) maxC = freq[idx];
                }
            }

            return maxV + maxC;
        }
    }
}
