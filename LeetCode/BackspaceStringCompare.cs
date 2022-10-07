using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class BackspaceStringCompare
    {
        public bool BackspaceCompare(string s, string t)
        {
            Stack<char> sStack = new Stack<char>();
            Stack<char> tStack = new Stack<char>();

            foreach (char item in s.ToCharArray())
            {
                if (item == '#')
                {
                    if(sStack.Count > 0) sStack.Pop();
                }
                else
                {
                    sStack.Push(item);
                }
            }

            foreach (char item in t.ToCharArray())
            {
                if (item == '#')
                {
                    if (tStack.Count > 0) tStack.Pop();
                }
                else
                {
                    tStack.Push(item);
                }
            }

            while (sStack.Count > 0 && tStack.Count > 0)
            {
                if (sStack.Peek() == tStack.Peek())
                {
                    sStack.Pop();
                    tStack.Pop();
                }
                else {
                    break;
                }
            }

            return sStack.Count == 0 && tStack.Count == 0;
        }
    }
}
