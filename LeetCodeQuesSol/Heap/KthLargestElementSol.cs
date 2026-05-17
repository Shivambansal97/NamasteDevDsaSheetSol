using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Heap
{
    public class KthLargestElementSol
    {
        public int FindKthLargest(int[] nums, int k)
        {
            PriorityQueue<int, int> que = new();

            for(int i=0; i<nums.Length; i++)
            {
                que.Enqueue(nums[i], nums[i]);

                if(que.Count > k)
                {
                    que.Dequeue();
                }
            }

            return que.Dequeue();
        }
    }
}
