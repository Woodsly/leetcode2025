using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class FindMissingAndRepeatedValues
    {
        public static int[] FindMissingRepeatedValues(int[][] grid)
        {
            int n = grid.Length;
            int nSquared = n * n;
            int[] count = new int[nSquared + 1];

            foreach (var row in grid)
            {
                foreach (var num in row)
                {
                    count[num]++;
                }
            }

            int repeated = -1;
            int missing = -1;

            for (int i = 1; i <= nSquared; i++)
            {
                if (count[i] == 2)
                {
                    repeated = i;
                }
                else if (count[i] == 0)
                {
                    missing = i;
                }
            }

            return new int[] { repeated, missing};
        }
    }
}
