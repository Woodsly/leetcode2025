using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class MaximumAscendingSubarraySum
    {
        public static int MaxAscendingSum(int[] nums)
        {
            int maxSum = 0;
            int index = 0;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                if (i == nums.Length - 1)
                {
                    while (index <= i)
                    {
                        sum += nums[index];
                        index++;
                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
                else
                {
                    if (nums[i] >= nums[i + 1])
                    {
                        while (index <= i)
                        {
                            sum += nums[index];
                            index++;
                        }

                        if (sum > maxSum)
                        {
                            maxSum = sum;
                        }

                        sum = 0;
                    }
                }
            }

            return maxSum;
        }
    }
}
