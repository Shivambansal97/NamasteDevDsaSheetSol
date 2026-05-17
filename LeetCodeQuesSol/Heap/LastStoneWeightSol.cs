using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Heap
{
    public class LastStoneWeightSol
    {
        public int LastStoneWeight(int[] stones)
        {
            PriorityQueue<int, int> que = new();

            foreach(int val in stones)
            {
                que.Enqueue(val, -val);
            }

            while(que.Count > 1)
            {
                int value = Math.Abs(que.Dequeue() - que.Dequeue());

                if (value > 0){
                    que.Enqueue(value, -value);
                }
            }

            if(que.Count == 0)
            {
                return 0;
            }

            return que.Dequeue();

        }
    }
}
