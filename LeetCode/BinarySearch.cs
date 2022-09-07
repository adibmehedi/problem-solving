using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {

            int left = 0;
            int right = nums.Length -1;

            while (left <= right)
            {
                int pointer = left + (right - left) / 2;
                if (nums[pointer] == target) { return pointer; }

                if (nums[pointer] > target) // go left
                {
                    right = pointer -1;
                }

                if (nums[pointer] < target) // go right
                {
                    left = pointer + 1;
                }
            }

            return -1;

        }
    }
}
