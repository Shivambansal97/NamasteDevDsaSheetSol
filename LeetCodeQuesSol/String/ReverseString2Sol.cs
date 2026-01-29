using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.String
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/reverse-string-ii/
    /// </summary>
    public class ReverseString2Sol
    {
        public string ReverseStr(string s, int k)
        {
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i += 2 * k)
            {
                int left = i;
                int right = Math.Min(i + k - 1, arr.Length - 1);
                while (left < right)
                {
                    (arr[left], arr[right]) = (arr[right], arr[left]);
                    left++;
                    right--;
                }
            }
            return new string(arr);
        }
    }
}
