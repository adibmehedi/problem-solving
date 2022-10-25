using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CheckIfTwoStringArraysAreEquivalent
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            return string.Join(string.Empty, word1) == string.Join(string.Empty, word2);
        }
    }
}
