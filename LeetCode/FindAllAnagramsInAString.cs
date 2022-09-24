using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class FindAllAnagramsInAString
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            char[] sArray = s.ToCharArray();
            char[] pArray = p.ToCharArray();
            IList<int> result = new List<int>();
            int[] sCounts = new int[26];
            int[] pCounts = new int[26];

            if (s.Length < p.Length) return result;

            // prepare p Array & calcualte sCounts 0 to p length
            int i = 0, j = 0;
            for (; i < pArray.Length; i++)
            {
                sCounts[sArray[i] - 'a']++;
                pCounts[pArray[i] - 'a']++;
            }

            for (; i < sArray.Length; i++)
            {
                if (Enumerable.SequenceEqual(sCounts, pCounts))
                {
                    result.Add(j);
                }

                //decrease last leftmost item and rightmost
                sCounts[sArray[i] - 'a']++;
                sCounts[sArray[j] - 'a']--;
                j++;
            }

            if (Enumerable.SequenceEqual(sCounts, pCounts))
            {
                result.Add(j);
            }

            return result;
        }
    }
}
