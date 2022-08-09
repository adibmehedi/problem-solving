using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class FindPivotIndex
    {
        public static int Solution(int[] nums) 
        {
            int sum = 0;
            int leftSum = 0;
            
            for (int i = 0; i < nums.Length; i++) { sum += nums[i]; }


            for (int index = 0; index < nums.Length; ++index)
            {
                int current = nums[index];
                if (leftSum == sum - leftSum - current) {
                    return index; 
                }
                leftSum += current;
            }

            return -1;

        }
    }
}
