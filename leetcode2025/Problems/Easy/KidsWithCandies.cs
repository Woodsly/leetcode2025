using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class KidsWithCandies
    {
        public static IList<bool> KidsWithCandy(int[] candies, int extraCandies)
        {
            bool[] result = new bool[candies.Length];

            int maxCandy = candies.Max();

            for (int i = 0; i < candies.Length; i++)
            {
                result[i] = candies[i] + extraCandies >= maxCandy;
            }

            return result;
        }
    }
}
