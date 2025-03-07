using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class GreatestCommonDivisorofStrings
    {
        public static string GcdOfStrings(string str1, string str2)
        {
            string gcd = "";

            if (str1 + str2 != str2 + str1)
            {
                return gcd;
            }

            int len1 = str1.Length;
            int len2 = str2.Length;

            if (len1 <= len2)
            {
                for (int i = len1; i > 0; i--)
                {
                    if (FindGcd(i, len1, len2))
                    {
                        gcd = str1.Substring(0, i);
                        break;
                    }
                }
            }
            else
            {
                for (int i = len2; i > 0; i--)
                {
                    if (FindGcd(i, len1, len2))
                    {
                        gcd = str2.Substring(0, i);
                        break;
                    }
                }
            }

            return gcd;
        }

        public static bool FindGcd(int i, int length1, int length2)
        {
            if (length1 % i != 0 || length2 % i != 0)
            {
                return false;
            }

            return true;
        }
    }
}
