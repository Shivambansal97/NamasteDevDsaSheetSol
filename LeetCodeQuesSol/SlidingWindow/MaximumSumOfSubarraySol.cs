using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.SlidingWindow
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/maximum-sum-of-subarray-of-size-k/
    /// </summary>
    public class MaximumSumOfSubarraySol
    {
        public long MaximumSubarraySum(int[] nums, int k)
        {
            int left = 0;
            long sum = 0;
            long maxSum = 0;

            Dictionary<int, int> occurance = new();

            for(int i=0; i<nums.Length; i++)
            {
                if (occurance.ContainsKey(nums[i]) && left <= occurance[nums[i]] && i >= occurance[nums[i]])
                {
                    left = occurance[nums[i]];
                    sum = nums[i];
                    continue;
                }

                if (!occurance.ContainsKey(nums[i]))
                    occurance.Add(nums[i], i);
                
                if( i - left > k - 1)
                {
                    sum = sum - nums[left] + nums[i];
                    left++;
                }
                else
                {
                    sum = sum + nums[i];
                }                                   

                if(sum > maxSum && i-left >= k-1)
                {
                    maxSum = sum;
                }
            }

            return maxSum;
        }
    }
}
