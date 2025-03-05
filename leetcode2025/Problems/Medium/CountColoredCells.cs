using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Medium
{
    public static class CountColoredCells
    {
        public static long ColoredCells(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            long[] longArray = new long[n];

            longArray[0] = 1;
            longArray[1] = 5;

            for (int i = 2; i < n; i++)
            {
                longArray[i] = longArray[i-1] + (longArray[i - 1] - longArray[i - 2]) + 4;
            }

            return longArray[n - 1];
        }
    }
}
