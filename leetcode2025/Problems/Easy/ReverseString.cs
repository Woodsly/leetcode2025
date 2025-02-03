using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class ReverseString
    {
        public static void ReverseStringer(char[] s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++,j--)
            {
                char temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }
        }
    }
}
