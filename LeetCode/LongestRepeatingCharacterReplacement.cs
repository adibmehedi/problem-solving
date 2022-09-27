using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    class LongestRepeatingCharacterReplacement
    {
        public int CharacterReplacement(string s, int k)
        {
            char[] sChars = s.ToCharArray();
            int[] dictionaryCount = new int[26]; // dictinoary is slower
            int leftPointer = 0;
            int rightPointer = 0;
            int result = 0;

            while (rightPointer <= sChars.Length) 
            {

                int diffCharacters = dictionaryCount.Sum() - dictionaryCount.Max();
                if (diffCharacters <= k) 
                {
                    result = Math.Max(result, rightPointer - leftPointer);
                    if (rightPointer < sChars.Length) { dictionaryCount[sChars[rightPointer] - 'A']++; }
                    rightPointer++;
                }
                else {
                    dictionaryCount[sChars[leftPointer] - 'A']--;
                    leftPointer++;
                }
            }

            return result;
        }
    }
}
