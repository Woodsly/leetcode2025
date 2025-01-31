using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Medium
{
    public static class CombinationSum
    {
        //https://leetcode.com/problems/combination-sum/description/

        //need to come back to this one to figure out how code can be changed so candidates dont add ints smaller than themselves
        //update 5 mins later - we solved it lol
        //had to pass new array where candidates >= candidates[i] to the recursive function
        public static IList<IList<int>> CombinationAdder(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            Array.Sort(candidates);

            Backtrack(candidates, target, 0, new List<int>(), result);

            return result;
        }

        private static void Backtrack(int[] candidates, int target, int sum, List<int> list, List<IList<int>> result)
        {
            if (sum == target)
            {
                result.Add(new List<int>(list));
                return;
            }

            for (int i = 0; i < candidates.Length; i++)
            {
                if (sum + candidates[i] <= target)
                {
                    list.Add(candidates[i]);

                    Backtrack(candidates.Where(c => c >= candidates[i]).ToArray(), target, sum + candidates[i], list, result);

                    list.RemoveAt(list.Count - 1);
                }
                if (sum + candidates[i] > target)
                {
                    break;
                }
            }
        }
    }
}
