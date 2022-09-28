using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int required = target - nums[i];
                if (dic.ContainsKey(required))
                {
                    var requiredIndex = dic[required];
                    return new int[] { i, requiredIndex };
                }

                if (!dic.ContainsKey(nums[i])) { dic.Add(nums[i], i); }
            }

            return result;
        }
    }
}
