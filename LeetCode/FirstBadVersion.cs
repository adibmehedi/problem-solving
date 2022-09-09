using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class FirstBadVersion
    {
        public static bool IsBadVersion(int x) {
            return x == 1000000000 ? false: true;
        }

        //public int find(int low, int high)
        //{
        //    int middle = low + (high - low);
        //    if()
        //}
        public static int FirstBadVersionSolution(int n)
        {
            int low = 0;
            int high = n;

            while (low <= high)
            {
                int middle = low + (high - low) / 2;
                bool isBad = IsBadVersion(middle);

                if (isBad == true)
                {
                    high = middle - 1;
                }
                else {
                    low = middle + 1;
                }

            }

            return low;
        }
    }
}
