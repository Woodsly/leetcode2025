using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class PlusOne
    {
        public static int[] PlusOner(int[] digits)
        {
            string stringDigits = "";

            foreach (int i in digits)
            {
                stringDigits += i;
            }

            stringDigits = stringDigits.Trim();

            BigInteger digit = BigInteger.Parse(stringDigits);
            digit++;

            stringDigits = digit.ToString();

            int[] result = new int[stringDigits.Length];

            for (int i = 0; i < stringDigits.Length; i++)
            {
                result[i] = int.Parse(stringDigits[i].ToString());
            }

            return result;
        }
    }
}
