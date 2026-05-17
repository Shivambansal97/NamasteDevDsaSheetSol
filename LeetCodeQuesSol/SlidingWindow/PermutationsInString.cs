using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.SlidingWindow
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/permutation-in-string/
    /// </summary>
    public class PermutationsInString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;

            int[] hashS1 = new int[26];
            int[] hashS2 = new int[26];

            // Step 1: Build frequency arrays for s1 and the first window in s2
            for (int i = 0; i < s1.Length; i++)
            {
                hashS1[s1[i] - 'a']++;
                hashS2[s2[i] - 'a']++;
            }


            // Step 2: Count how many of the 26 slots already match
            int matches = 0;
            for (int i = 0; i < 26; i++)
            {
                if (hashS1[i] == hashS2[i])
                    matches++;
            }

            int left = 0;
            for (int right = s1.Length; right < s2.Length; right++)
            {
                if (matches == 26)
                    return true;

                // Add incoming character at right edge
                int incoming = s2[right] - 'a';
                hashS2[incoming]++;
                if (hashS2[incoming] == hashS1[incoming])
                    matches++;
                else if (hashS2[incoming] == hashS1[incoming] + 1)
                    matches--;

                // Remove outgoing character at left edge
                int outgoing = s2[left] - 'a';
                hashS2[outgoing]--;
                if (hashS2[outgoing] == hashS1[outgoing])
                    matches++;
                else if (hashS2[outgoing] == hashS1[outgoing] - 1)
                    matches--;

                left++;
            }

            // Check the last window
            return matches == 26;
        }
    }
}
