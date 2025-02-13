using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Medium
{
    public static class Combinations
    {
        public static IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> result = new List<IList<int>>();

            BackTrack(1, result, n, k, new List<int>());

            return result;
        }

        public static void BackTrack(int start, IList<IList<int>> result, int n, int k, List<int> combo)
        {
            if (combo.Count == k)
            {
                result.Add(new List<int>(combo));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                combo.Add(i);
                BackTrack(i + 1, result, n, k, combo);
                combo.RemoveAt(combo.Count - 1);
            }
        }
    }
}
