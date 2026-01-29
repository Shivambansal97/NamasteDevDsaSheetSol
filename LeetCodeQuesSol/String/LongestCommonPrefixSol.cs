using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.String
{
    public class LongestCommonPrefixSol
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int len = strs.Length;

            if(len == 1)
            {
                return strs[0];
            }

            int j = 0;
            int i = 0;
            char temp = ' ';
            string result = "";            

            while(true)
            {
                while(i < len)
                {
                    if(j >= strs[i].Length)
                    {
                        return result;
                    }
                    if (i == 0)
                    {
                        temp = strs[0][j];
                        
                    }
                    else if (temp != strs[i][j])
                    {
                        return result;
                    }
                    i++;
                }

                result += temp;
                j++;
                i = 0;

            }
        }
    }
}
