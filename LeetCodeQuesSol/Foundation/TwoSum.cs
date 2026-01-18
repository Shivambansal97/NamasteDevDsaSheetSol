namespace LeetCodeQuesSol.Foundation
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/two-sum/submissions/
    /// </summary>
    internal static class TwoSumSol
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int comp = target - nums[i];

                if (map.TryGetValue(comp, out int value))
                {
                    return [value, nums[i]];
                }

                map[nums[i]] = i;
            }

            return [];
        }
    }
}
