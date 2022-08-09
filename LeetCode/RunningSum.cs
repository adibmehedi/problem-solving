using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class RunningSum
    {
        public static int[] RunningSumSolution(int[] nums)
        {
            
            for (int counter = 0; counter < nums.Length; counter++)
            {
                int currentIndexvalue = nums[counter];
                if (counter > 0) { nums[counter] = currentIndexvalue + nums[counter - 1]; }
            }
            return nums;
        }
    }
}
