using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ContainsDuplicateII
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            bool isFound = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    int j = dict[nums[i]];
                    if (Math.Abs(i - j) <= k) { isFound = true; }
                }
                else { 
                    dict.Add(nums[i], i);   
                }
            }
            return isFound;
        }
    }
}
