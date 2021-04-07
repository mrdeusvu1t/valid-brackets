using System;
using System.Collections.Generic;

namespace ValidBracketsTask
{
    /// <summary>
    /// Provides methods to validate of the correct placement of brackets in the string.
    /// </summary>
    public class BracketsValidator
    {
        
        /// <summary>
        /// Validates of the correct placement of brackets in the string.
        /// </summary>
        /// <param name="input">String to validate.</param>
        /// <returns>true if the pairs of brackets are placed correctly, otherwise - false.</returns>
        /// <exception cref="ArgumentNullException">Thrown if string is null.</exception>
        public bool IsValid(string input)
        {
            if (input is null)
            {
                throw new ArgumentNullException($"{nameof(input)} is null.");
            }

            Stack<char> stack = new Stack<char>();

            foreach (Char c in input)
            {
                switch (c)
                {
                    case '{':
                    case '(':
                    case '[':
                        stack.Push(c);
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Peek() != '{')
                        {
                            return false;
                        }
                        stack.Pop();
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Peek() != '(')
                        {
                            return false;
                        }
                        stack.Pop();
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Peek() != '[')
                        {
                            return false;
                        }
                        stack.Pop();
                        break;
                    default:
                        break;
                }
            }

            return stack.Count == 0;
        }
    }
}
