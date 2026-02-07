using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.SlidingWindow
{
    public class HaystackNeedleSol
    {
        public int StrStr(string haystack, string needle)
        {
            int i = 0, j = 0;
            int result = -1;

            while (i < haystack.Length && j < needle.Length)
            {
                if (haystack[i] == needle[j])
                {
                    if (j == 0)
                    {
                        result = i;
                    }
                    j++;
                }
                else
                {
                    if(j > 0)
                    {
                        j = 0;
                        i = result+1;
                        result = -1;
                        continue;
                    }
                }
                i++;
            }

            if(j >= needle.Length)
            {
                return result;
            }

            return -1;
        }
    }
}
