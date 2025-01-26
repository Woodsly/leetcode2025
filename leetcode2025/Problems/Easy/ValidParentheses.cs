using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            List<char> openings = ['(', '{', '['];
            List<char> closings = [')', '}', ']'];

            // Create a stack of characters
            Stack<char> charStack = new Stack<char>();

            //stacks work on a last in first out principle
            //last item added is first one removed

            if (s.Count() == 1)
            {
                return false;
            }

            if (closings.Any(c => c.Equals(s[0])))
            {
                return false;
            }

            foreach (char c in s)
            {
                if (openings.Any(o => o.Equals(c)))
                {
                    //push any openings into the stack!
                    charStack.Push(c);
                }
                else if (closings.Any(c => c.Equals(c)))
                {
                    //if we have a closing with nothing in the stack then false
                    if (!charStack.Any())
                    {
                        return false;
                    }

                    if (c == ')')
                    {
                        if (charStack.First() == '(')
                        {
                            charStack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (c == '}')
                    {
                        if (charStack.First() == '{')
                        {
                            charStack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (c == ']')
                    {
                        if (charStack.First() == '[')
                        {
                            charStack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            //checking to see if there are any openings that never got closed
            if (charStack.Any())
            {
                return false;
            }

            return true;
        }
    }
}
