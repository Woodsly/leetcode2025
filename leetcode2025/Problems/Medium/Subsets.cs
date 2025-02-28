using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Medium
{
    public static class Subsets
    {
        public static IList<IList<int>> SubsetsSolver(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();

            Backtrack(result, 0, new List<int>(), nums);

            return result;
        }

        private static void Backtrack(List<IList<int>> result, int index, List<int> combination, int[] nums)
        {
            result.Add(new List<int>(combination));

            for (int i = index; i < nums.Length; i++)
            {
                combination.Add(nums[i]);
                Backtrack(result, i + 1, combination, nums);
                combination.Remove(nums[i]);
            }
        }
    }
}
