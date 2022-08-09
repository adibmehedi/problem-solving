using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class IsSubsequence
    {
        public static bool Solution(string s, string t) 
        {
            Queue<char> charQueue = new Queue<char>(s.ToCharArray());
            char[] charArray = t.ToCharArray();
            

            for (int index = 0; index < charArray.Length; index++)
            {
                if (charQueue.Count > 0) { 
                    char current = charQueue.Peek();
                    if (charArray[index] == current) { charQueue.Dequeue();  }
                }
            }
            return (charQueue.Count > 0) ? false : true;


        }
    }
}
