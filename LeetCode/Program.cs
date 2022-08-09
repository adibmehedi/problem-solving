using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.TwoSum(new int[] { 2, 7, 11, 15, 9 }, 9);
            //Console.WriteLine(Program.MaxSubArray(new int[] { -1,  }));
            //Console.WriteLine(Program.MajorityElement(new int[] { 3, 2, 3 }));
            //Console.WriteLine(Program.MaxDistance(new int[] { 4,4,4,11,4,4,11,4,4,4,4,4 }));
            //Console.WriteLine(Program.MaximumDifference(new int[] { 999, 997, 980, 976, 948, 940, 938, 928, 924, 917, 907, 907, 881, 878, 864, 862, 859, 857, 848, 840, 824, 824, 824, 805, 802, 798, 788, 777, 775, 766, 755, 748, 735, 732, 727, 705, 700, 697, 693, 679, 676, 644, 634, 624, 599, 596, 588, 583, 562, 558, 553, 539, 537, 536, 509, 491, 485, 483, 454, 449, 438, 425, 403, 368, 345, 327, 287, 285, 270, 263, 255, 248, 235, 234, 224, 221, 201, 189, 187, 183, 179, 168, 155, 153, 150, 144, 107, 102, 102, 87, 80, 57, 55, 49, 48, 45, 26, 26, 23, 15 }));
            //Console.WriteLine(Program.MaximumDifference(new int[] { 1,2 }));
            //Console.WriteLine(Program.ValidParentheses("(}"));
            //Console.WriteLine(RunningSum.RunningSumSolution(new int[] { 1,2,3,4 }));
            //Console.Write(FindPivotIndex.Solution(new int[] { 2, 1, -1 }));
            Console.Write(IsomorphicStrings.Solution("foo", "bar"));
        }

        public static bool ValidParentheses(string s) {
            Stack<char> inputStack = new Stack<char>();
            int index = 0;
            while (index < s.Length) {
                char current = s[index];
                if (current == '(' || current == '{' || current == '[')
                {
                    inputStack.Push(current);
                }
                else {

                    if (
                        (inputStack.Count > 0) && 
                        ((inputStack.Peek() == '(' && current == ')') || (inputStack.Peek() == '{' && current == '}') || (inputStack.Peek() == '[' && current == ']')))
                    {
                        inputStack.Pop();
                    }
                    else {
                        return false;
                    }
                }
                index++;
            }

            return inputStack.Count == 0; // input single char: ( 
        }


        //[1...1000]
        //a3+b3 = c3 +d3
        //10^7 = 1sec
        //Kadane
        //Cyliclally rotate
             
        public int RomanToInt(string s)
        {

            int number = 0;

            Dictionary<string, int> symbols = new Dictionary<string, int>();
            symbols.Add("M", 1000);
            symbols.Add("CM", 900);
            symbols.Add("D", 500);
            symbols.Add("CD", 400);
            symbols.Add("C", 100);
            symbols.Add("XC", 90);
            symbols.Add("L", 50);
            symbols.Add("XL", 40);
            symbols.Add("X", 10);
            symbols.Add("IX", 9);
            symbols.Add("V", 5);
            symbols.Add("IV", 4);
            symbols.Add("I", 1);


            for (int i = 0; i < s.Length - 1; i++)
            {
                if (i == s.Length - 1)
                {
                    number += symbols[s[i].ToString()];
                    break;
                }

                // first two value maches with symbols then calc
                string currentPair = s[i].ToString() + s[i + 1].ToString();
                if (symbols.ContainsKey(currentPair))
                {
                    number += symbols[currentPair];
                }
                else
                {
                    number += symbols[s[i].ToString()];
                }

            }

            return number;


        }

        //TODO: TwoPointer
        // sort - nLogn
        // start calc with two pointer. 
        public static int[] TwoSum(int[] nums, int target)
        {
            //nums = [2,7,11,15], target = 9
            // 0,1,2,3

            //DS (Value =>Indexs[])
            var numList = new Dictionary<int, int[]>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numList.ContainsKey(nums[i]))
                {
                    var indexList = (numList[nums[i]].ToList());
                    indexList.Add(i);
                    numList[nums[i]] = indexList.ToArray();
                } else { 
                    numList.Add(nums[i], new int[] { i});
                }
            }

            


            for (int i = 0; i < nums.Length; i++)
            {
                int requiredValue = target - nums[i];
                if (numList.ContainsKey(requiredValue))
                {
                    var requiredValueIndexArray = numList[requiredValue];
                    if (requiredValueIndexArray.Length > 1) //[3,3] 6
                    {
                        return requiredValueIndexArray;
                    }

                    if (requiredValue != nums[i])  //[3,2,4] 6
                    {            
                        return new int[] { i, (requiredValueIndexArray)[0] };
                    }
                 
                }
                
            }

            return new int[] { };

        }


        //public static int MaxProfit(int[] prices)
        //{

        //    bool isTradeable = false;
        //    int profit = 0;
        //    int buyPrice = 0;
        //    int sellPrice = 0;

        //    if (prices.Length < 2) { return profit; }

        //    int currentBuyPrice = prices[0];
        //    int currentSellPrice = prices[1];
        //    int currentProfit = currentSellPrice - currentBuyPrice;

        //    for (int i = 2; i < prices.Length; i++)             // 7,1,5,3,6,4
        //    {

        //        if (currentSellPrice < prices[i]) { currentSellPrice = prices[i]; }
        //        if (currentBuyPrice > prices[i]) { currentBuyPrice = prices[i]; }

        //        if (currentProfit < currentSellPrice) // best condition
        //        {
        //            isTradeable = true;
        //            buyPrice = currentBuyPrice;
        //            sellPrice = currentSellPrice;
        //            currentProfit
        //        }



        //        if (currentSellPrice < currentBuyPrice )
        //        {
        //            currentBuyPrice = currentSellPrice;
        //        }

   

        //        currentSellPrice = prices[i];
                
        //    }

        //    profit = buyPrice - sellPrice;
        //    return profit;


        //}

        public static int MaxSubArray(int[] nums) 
        {
            //int maxSum = nums[0];
            //int leftPointerIndex;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    leftPointerIndex = i;
            //    int tempSum = 0;
            //    for (int j = leftPointerIndex; j < nums.Length; j++)
            //    {
            //        tempSum = tempSum + nums[j];
            //        if (maxSum < tempSum) 
            //        {
            //            maxSum = tempSum;
            //        }
            //    }
            //}

            //return maxSum;


            //10,-1, -1,11

            int maxSum = nums[0];
            int currentSubarrayMax = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currentSubarrayMax = (currentSubarrayMax + nums[i] > nums[i]) ? currentSubarrayMax + nums[i] : nums[i];
                maxSum = (maxSum > currentSubarrayMax) ? maxSum : currentSubarrayMax;
            }

            return maxSum;


        }

        public static int MajorityElement(int[] nums)
        {
            int counter = 1;
            int currentElem = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (counter == 0) { 
                    currentElem = nums[i]; 
                    counter++; 
                }
                else {
                    counter = currentElem == nums[i] ? counter + 1 : counter - 1;
                }
           
            }

            return currentElem;
        }

        public static int MaxDistance(int[] colors)
        {
            int prevColorIndex = 0;
            int prevColorFromLeft = colors[prevColorIndex];
          
            int maxDistance = 0;
            
            for (int i = 1; i < colors.Length; i++)
            {
                if (prevColorFromLeft != colors[i])
                {
                    int distance = Math.Abs(i - prevColorIndex);
                   
                    if (maxDistance < distance) 
                    {
                        maxDistance = distance;
                    };
                }
            }

            prevColorIndex = colors.Length -1;
            int prevColorFromRight = colors[prevColorIndex];

            for (int i = colors.Length -2; i >= 0; i--)
            {
                if (prevColorFromRight != colors[i])
                {
                    int distance = Math.Abs(i - prevColorIndex);

                    if (maxDistance < distance)
                    {
                        maxDistance = distance;
                    };
                }
            }


            return maxDistance;
        }

        public static int MaximumDifference(int[] nums)
        {
            int minI = nums[0];
            int maxJ = nums[1];
            int maxDistance = maxJ - minI;

            for (int i = 1; i < nums.Length - 1; i++) 
            {
                if (minI > nums[i]) 
                { 
                    minI = nums[i];
                    maxJ = nums[i + 1];
                }

                if (maxJ<nums[i+1])
                {
                    maxJ = nums[i+1];
                }
                int distance = maxJ - minI;
                if (maxDistance < distance) { maxDistance = distance; }
            }

            return (maxDistance <=0)? -1: maxDistance;

        }

    }
}
