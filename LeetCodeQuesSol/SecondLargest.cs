using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol
{
    internal static class SecondLargest
    {
        internal static int SecondHighest(string s)
        {
            int highest = -1, second = -1;
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    int num = c - '0';
                    if (num > highest)
                    {
                        second = highest;
                        highest = num;
                    }
                    else if (num < highest && num > second)
                    {
                        second = num;
                    }
                }
            }
            return second;
        }
    }
}
