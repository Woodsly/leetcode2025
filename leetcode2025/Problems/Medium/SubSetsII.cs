using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Medium
{
    public static class SubSetsII
    {
        public static IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();

            result.Add(new List<int>());

            int[] sortedNums = nums.OrderBy(n => n).ToArray();

            Backtrack(sortedNums, result, 0, new List<int>());

            return result;
        }

        private static void Backtrack(int[] sortedNums, List<IList<int>> result, int v, List<int> list)
        {
            if (!result.Any(r => r.SequenceEqual(list)))
            {
                    result.Add(new List<int>(list));
            }

            for (int i = v; i < sortedNums.Count(); i++)
            {
                list.Add(sortedNums[i]);
                //we pass i+1 to backtrack so we can continue on and check the next index
                //passing v + 1 would result in us checking the same index over and over, because
                //v will not increment with i through the for loop
                Backtrack(sortedNums, result, i + 1, list);
                list.Remove(sortedNums[i]);
            }

            return;
        }
    }
}
