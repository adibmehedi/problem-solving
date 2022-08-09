using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class IsomorphicStrings
    {
        public static bool Solution(string s, string t)
        {
            char[] firstCharArray = s.ToCharArray();
            char[] secondCharArray = t.ToCharArray();
            int firstCounter = 1; int secondCounter = 1;
            Dictionary<char, int> firstCharPool = new Dictionary<char, int>();
            Dictionary<char, int> secondCharPool = new Dictionary<char, int>();
            for (int index = 0; index < firstCharArray.Length; index++)
            {
                if (!firstCharPool.ContainsKey(firstCharArray[index])) 
                {
                    firstCharPool.Add(firstCharArray[index], firstCounter++);
                }
                if (!secondCharPool.ContainsKey(secondCharArray[index]))
                {
                    secondCharPool.Add(secondCharArray[index], secondCounter++);
                }
            }


            for (int counter = 0; counter < firstCharArray.Length; counter++)
            {
                if (firstCharPool[firstCharArray[counter]] != secondCharPool[secondCharArray[counter]])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
