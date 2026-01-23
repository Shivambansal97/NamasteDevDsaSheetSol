using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.String
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/jewels-and-stones/
    /// </summary>
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            var jewelSet = new HashSet<char>(jewels);
            int result = 0;

            foreach(char s in stones)
            {
                if (jewelSet.Contains(s))
                {
                    result++;
                }
            }

            return result;
        }
    }
}
