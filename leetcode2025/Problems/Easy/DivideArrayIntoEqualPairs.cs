using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class DivideArrayIntoEqualPairs
    {
        public static bool DivideArray(int[] nums)
        {
            bool answer = true;

            int[] count = new int[nums.Max() + 1];

            int[] sortedNums = nums.OrderBy(n => n).ToArray();

            for (int i = 0; i < sortedNums.Length; i++)
            {
                count[sortedNums[i]]++;
            }

            if (count.Any(c => c%2 != 0))
            {
                answer = false;
            }

            return answer;
        }
    }
}
