using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class MinimumRecolorstoGetKConsBlocks
    {
        public static int MinimumRecolors(string blocks, int k)
        {
            int minOperations = 0;

            int n = blocks.Length;

            List<int> operationList = new List<int>();

            if (k > n)
            {
                return -1;
            }

            int index = n - k;

            for (int i = 0; i <= index; i++)
            {
                int count = 0;
                foreach (char x in blocks.Substring(i, k))
                {
                    if (x == 'B')
                    {
                        count++;
                    }
                }
                operationList.Add(count);
            }

            return k - operationList.Max();
        }
    }
}
