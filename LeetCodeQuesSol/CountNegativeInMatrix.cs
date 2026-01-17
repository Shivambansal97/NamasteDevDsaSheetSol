using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix/
    /// </summary>
    internal static class CountNegativeInMatrix
    {
        public static int CountNegatives(int[][] grid)
        {
            int row = grid.Length;
            int col = grid[0].Length;
            int count = 0;
            int r = row - 1;
            int c = 0;

            while (r>=0 && c < col)
            {
                if (grid[r][c] < 0)
                {
                    count += col - c;
                    r--;
                }
                else
                {
                    c++;
                }
            }

            return count;
        }

        //public static int CountNegatives(int[][] grid)
        //{
        //    int count = 0;
        //    for (int i = 0; i < grid.Length; i++)
        //    {
        //        for (int j = 0; j < grid[i].Length; j++)
        //        {
        //            if (grid[i][j] < 0)
        //            {
        //                count++;
        //            }
        //        }
        //    }
        //    return count;
        //}
    }
}
