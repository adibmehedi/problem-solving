using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class DecodeStringSolution
    {
        public string DecodeString(string s)
        {
            //2[abc]3[cd]ef  --> "abcabccdcdcdef"

            Stack<int> intStack = new Stack<int>();
            Stack<StringBuilder> strStack = new Stack<StringBuilder>();
            StringBuilder current = new StringBuilder();

            int count = 0;

            foreach (char character in s)
            {
                if (IsDigitpublic(character))
                {
                    count = 10 * count + (character - '0');
                }
                else if (character == '[') // if found [ send all res to stack
                {
                    intStack.Push(count);
                    strStack.Push(current);

                    current = new StringBuilder();
                    count = 0;
                }
                else if (character == ']') // start with ]
                {
                    StringBuilder temp = current;
                    current = strStack.Pop();
                    for (count = intStack.Pop(); count > 0; count--)
                    {
                        current.Append(temp);
                    }
                }
                else
                {
                    current.Append(character);
                }
            }

            return current.ToString();

        }

        bool IsDigitpublic(char character)
        {
            return character >= '0' && character <= '9';
        }
    }
}
