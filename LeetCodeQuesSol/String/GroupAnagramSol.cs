using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeQuesSol.String
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/group-anagrams/
    /// </summary>
    public class GroupAnagramSol
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> map = new();
            foreach (string word in strs)
            {
                string signature = string.Concat(word.OrderBy(c => c));
                if (!map.ContainsKey(signature))
                    map[signature] = new List<string>();
                map[signature].Add(word);
            }
            return map.Values.ToList();
        }
    }
}
