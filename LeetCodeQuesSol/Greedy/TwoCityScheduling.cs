using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Greedy
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/two-city-scheduling/
    /// </summary>
    public static class TwoCityScheduling
    {
        public static int TwoCitySchedCost(int[][] costs)
        {
            // Sort by (A - B): most beneficial to send to A come first.
            Array.Sort(costs, (x, y) => (x[0] - x[1]).CompareTo(y[0] - y[1]));

            int n = costs.Length / 2;
            int total = 0;

            for (int i = 0; i < costs.Length; i++)
            {
                total += i < n ? costs[i][0] : costs[i][1];
            }

            return total;       
        }        
    }    
}
