using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.String
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/find-words-containing-a-specific-character/
    /// </summary>
    public class FindWordsContainingChar
    {
        public IList<int> FindWordsContaining(string[] words, char x)
        {
            IList<int> result = [];

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(x))
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
