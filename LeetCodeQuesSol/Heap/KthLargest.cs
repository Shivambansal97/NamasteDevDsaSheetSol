using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Heap
{
    public class KthLargest
    {
        PriorityQueue<int, int> que = new();
        int size = 0;

        public KthLargest(int k, int[] nums)
        {
            size = k;
            for(int i=0; i<nums.Length; i++)
            {
                que.Enqueue(nums[i], nums[i]);

                if(que.Count > k)
                {
                    que.Dequeue();
                }
            }
        }

        public int Add(int val)
        {
            que.Enqueue(val, val);

            if (que.Count > size)
            {
                que.Dequeue();
            }

            return que.Peek();
        }
    }

    /**
     * Your KthLargest object will be instantiated and called as such:
     * KthLargest obj = new KthLargest(k, nums);
     * int param_1 = obj.Add(val);
    **/
}
