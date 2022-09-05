using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class BestTimeToBuyAndSellStock
    {
        //7,1,5,3,6,4
        public int MaxProfit(int[] prices)
        {
            int leftPointer = 0, rightPointer = 1;
            if (prices.Length == 1) { return 0; }
            int maxDiff = 0;
            while (rightPointer < prices.Length)
            {
                
                if (prices[leftPointer] < prices[rightPointer])
                {
                    int diff = prices[rightPointer] - prices[leftPointer];
                    maxDiff = Math.Max(diff, maxDiff);
                }
                else {
                    leftPointer = rightPointer;
                }
                rightPointer++;
            }

            return maxDiff;
        }
    }
}
