using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.SlidingWindow
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/container-with-most-water/
    /// </summary>
    public class WaterContainer
    {
        public int MaxArea(int[] height)
        {
            if (height == null || height.Length < 2)
                return 0;

            int left = 0;
            int right = height.Length - 1;
            int max = 0;

            while(left < right)
            {
                int h = Math.Min(height[left], height[right]);
                int area = h * (right - left);
                max = Math.Max(max, area);
                
                if (height[right] >= height[left])
                {
                    left++;
                }
                else
                {                 
                    right--;
                }
            }
            return max;
        }
    }
}
