using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class BullsAndCows
    {
        public string GetHint(string secret, string guess)
        {
            int[] countArray = new int[10];
            char[] sArray = secret.ToCharArray();
            char[] gArray = guess.ToCharArray();
            int bulls = 0;
            int cows = 0;

            for (int i = 0; i < sArray.Length; i++)
            {
                if (sArray[i] != gArray[i])
                {
                    countArray[sArray[i] - '0']++;
                }
            }

            for (int i = 0; i < gArray.Length; i++)
            {
                if (sArray[i] == gArray[i])
                {
                    bulls++;
                }
                else {
                    if (countArray[guess[i] - '0'] > 0) { cows++; }
                    countArray[guess[i] - '0']--;
                }

            }

            return $"{bulls}A{cows}B";

        }
    }
}
