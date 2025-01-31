using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class ClimbingStairs
    {
        //time limit exception/out of memory with this approach...
        //need to come back to this later
        public static int ClimbStairs(int n)
        {
            List<List<int>> result = new List<List<int>>();

            BackTrack(n, 0,new List<int>(), result);

            return result.Count;
        }

        private static void BackTrack(int target, int stepCount, List<int> list, List<List<int>> result)
        {
            if (stepCount == target)
            {
                result.Add(list);
                return;
            }

            if (stepCount + 1 <= target)
            {
                list.Add(1);
                BackTrack(target, stepCount + 1, list, result);
                list.Remove(1);
            }

            if (stepCount + 2 <= target)
            {
                list.Add(2);
                BackTrack(target, stepCount + 2, list, result);
                list.Remove(2);
            }
        }
    }
}
