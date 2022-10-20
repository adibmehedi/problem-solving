using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            Dictionary<int, string> symbols = new Dictionary<int, string>();
            symbols.Add(1000, "M");
            symbols.Add(900, "CM");
            symbols.Add(500, "D");
            symbols.Add(400, "CD");
            symbols.Add(100, "C");
            symbols.Add(90, "XC");
            symbols.Add(50, "L");
            symbols.Add(40, "XL");
            symbols.Add(10, "X");
            symbols.Add(9, "IX");
            symbols.Add(5, "V");
            symbols.Add(4, "IV");
            symbols.Add(1, "I");

            var sb = new StringBuilder();
          
            foreach (int n in symbols.Keys)
            {
                while (n <= num)
                {
                    sb.Append(symbols[n].ToString());
                    num = num - n;
                }
            }

            return sb.ToString();
            
        }
    }
}
