using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class OneStringSwap
    {
        public static bool AreAlmostEqual(string s1, string s2)
        {
            List<char> string1Char = new List<char>();
            List<char> string2Char = new List<char>();

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    string1Char.Add(s1[i]);
                    string2Char.Add(s2[i]);
                }
            }

            if (string1Char.Count() == 0)
            {
                return true;
            }
            else if (string1Char.Count() == 2)
            {
                return string1Char.OrderBy(c => c).SequenceEqual(string2Char.OrderBy(c => c));
            }

            return false;
        }
    }
}
