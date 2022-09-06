using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LongestPalindrome
    {
        public int LongestPalindromeSolution(string s)
        {
            char[] arr = s.ToCharArray();
            HashSet<char> collection = new HashSet<char>();
            int doubleCounter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (collection.Contains(arr[i]))
                {
                    doubleCounter++;
                    collection.Remove(arr[i]);
                }
                else {
                    collection.Add(arr[i]);
                }
            }

            return collection.Count > 0 ? doubleCounter * 2 + 1 : doubleCounter * 2;

        }
    }
}
