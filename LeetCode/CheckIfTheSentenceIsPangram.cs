using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CheckIfTheSentenceIsPangram
    {
        public bool CheckIfPangram(string sentence)
        {
            List<char> charList = new List<char>();
            foreach (char character in sentence)
            {
                if (!charList.Contains(character))
                { 
                    charList.Add(character);
                }
            }

            return charList.Count == 26 ? true : false; 
        }
    }


}
