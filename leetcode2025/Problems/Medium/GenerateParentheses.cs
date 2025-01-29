using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Medium
{
    public static class GenerateParentheses
    {
        //https://leetcode.com/problems/generate-parentheses/

        //recurise pathing

        //method calls itself until the length is twice the desired amount
        //https://www.youtube.com/watch?v=fCoQP7fFqow -- good info on recursion

        public static IList<string> GenerateParenthesis(int n)

        {
            List<string> result = new List<string>();
            Backtrack("", 0, 0, n, result);
            return result;
        }

        private static void Backtrack(string current, int open, int close, int n, List<string> result)
        {
            if (current.Length == 2 * n)
            {
                result.Add(current);
                return;
            }

            if (open < n)
            {
                Backtrack(current + "(", open + 1, close, n, result);
            }

            if (close < open)
            {
                Backtrack(current + ")", open, close + 1, n, result);
            }
        }
    }
}
