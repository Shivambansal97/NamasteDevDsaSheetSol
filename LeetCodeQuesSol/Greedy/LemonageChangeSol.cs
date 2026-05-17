using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Greedy
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/lemonade-change/
    /// </summary>
    internal static class LemonageChangeSol
    {
        public static bool LemonadeChange(int[] bills)
        {
            int change5 = 0;
            int change10 = 0;

            for(int i=0; i< bills.Length; i++)
            {
                if (bills[i] == 5)
                {
                    change5++;
                }
                else
                {
                    if (bills[i] == 10)
                    {                        
                        change5--;
                        change10++;
                    }
                    else
                    {
                        if (change10 >= 1)
                        {
                            change10--;
                            change5--;
                        }
                        else
                        {
                            change5 -= 3;
                        }
                    }
                }

                if(change5 < 0)
                {
                    return false;
                }
                
            }

            return change5 >= 0 ? true : false;

        }
    }
}
