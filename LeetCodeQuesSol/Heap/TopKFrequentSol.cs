using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.Heap
{
    public static class TopKFrequentSol
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dict = new();

            for(int i=0; i<nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], 1);
                }
                else
                {
                    dict[nums[i]]++;
                }
            }

            PriorityQueue<int, int> que = new();

            foreach(var value in dict)
            {
                que.Enqueue(value.Key, value.Value);

                if (que.Count > k)
                {
                    que.Dequeue();
                }
            }

            int[] sol = new int[k];

            for(int i=0; i<k; i++)
            {
                sol[i] = (que.Dequeue());
            }

            return sol;
        }

        public static int[] TopKFrequentUsingBucketSort(int[] nums, int k)
        {            
            // Step 1: Build frequency map
            var freq = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!freq.ContainsKey(num))
                    freq[num] = 0;
                freq[num]++;
            }

            // Step 2: Bucket by frequency (index = frequency, value = list of numbers)
            var buckets = new List<int>[nums.Length + 1];
            for (int i = 0; i < buckets.Length; i++)
                buckets[i] = new List<int>();

            foreach (var kvp in freq)
                buckets[kvp.Value].Add(kvp.Key);

            // Step 3: Collect k largest from right (highest frequency)
            var result = new List<int>();
            for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
                result.AddRange(buckets[i]);

            return [.. result.Take(k)];
        }    

    }
}
