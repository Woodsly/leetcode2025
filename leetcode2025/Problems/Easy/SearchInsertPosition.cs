using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
                else if (nums[i] > target)
                {
                    return i;
                }
                else if (i == nums.Length - 1 && nums[i] < target)
                {
                    return i + 1;
                }
            }

            return 0;
        }
    }
}
