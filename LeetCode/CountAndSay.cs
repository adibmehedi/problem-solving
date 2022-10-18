using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CountAndSaySolution
    {
        public string CountAndSay(int n)
        {
            if (n == 1) { return "1"; }

            StringBuilder sb = new StringBuilder(); 
            string prevStr = CountAndSay(n - 1);

            //calcualte prev str 11 => Two 1
            for (int i = 0; i < prevStr.Length; i++)
            {
                char c = prevStr[i];
                int count = 1;
                while (i + 1 < prevStr.Length && prevStr[i+1] == c)
                {
                    count++;
                    i++;
                }
                sb.Append(count + "" + c);
            }

            return sb.ToString();
        }
    }
}
