using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    class DeleteAndEarnSolution
    {
        public int DeleteAndEarn(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            int RANGE = 10001;
            int[] dp = new int[RANGE];

            foreach(var item in nums)
            {
                dp[item] += item;
            }

            for (int i = 2; i< RANGE; i++)
            {
                dp[i] = Math.Max(dp[i] + dp[i - 2], dp[i - 1]);
            }

            return dp[RANGE -1];

        }
    }
}
