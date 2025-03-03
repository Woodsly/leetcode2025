using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Medium
{
    public static class PartitionArrayPivot
    {
        public static int[] PivotArray(int[] nums, int pivot)
        {
            int[] afterPivot = new int[nums.Length];

            int[] smaller = nums.Where(n => n < pivot).ToArray();
            int[] equal = nums.Where(n => n == pivot).ToArray();
            int[] greater = nums.Where(n => n > pivot).ToArray();

            int index = 0;

            for (int i = 0; i < smaller.Length; i++, index++)
            {
                afterPivot[index] = smaller[i];
            }

            for (int i = 0; i < equal.Length; i++, index++)
            {
                afterPivot[index] = equal[i];
            }

            for (int i = 0; i < greater.Length; i++, index++)
            {
                afterPivot[index] = greater[i];
            }

            return afterPivot;
        }

        //public int[] PivotArray(int[] nums, int pivot)
        //{
        //    int[] result = new int[nums.Length];
        //    int left = 0, right = nums.Length - 1;

        //    for (int i = 0, j = nums.Length - 1; i < nums.Length; i++, j--)
        //    {
        //        if (nums[i] < pivot)
        //        {
        //            result[left] = nums[i];
        //            left++;
        //        }

        //        if (nums[j] > pivot)
        //        {
        //            result[right] = nums[j];
        //            right--;
        //        }
        //    }

        //    while (left <= right)
        //    {
        //        result[left] = pivot;
        //        left++;
        //    }

        //    return result;
        //}
    }
}
