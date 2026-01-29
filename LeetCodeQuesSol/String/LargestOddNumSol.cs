using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.String
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/largest-odd-number-in-string/
    /// </summary>
    public class LargestOddNumSol
    {
        public string LargestOddNumber(string num)
        {
            int i = num.Length - 1;

            while (i >= 0)
            {
                int digit = num[i] - '0';

                if (digit % 2 != 0) 
                {
                    return num.Substring(0, i+1);
                }

                i--;
                
            }

            return "";
        }
    }
}
