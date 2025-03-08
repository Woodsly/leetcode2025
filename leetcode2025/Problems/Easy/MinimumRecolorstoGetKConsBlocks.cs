using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class MinimumRecolorstoGetKConsBlocks
    {
        //public static int MinimumRecolors(string blocks, int k)
        //{
        //    int n = blocks.Length;

        //    List<int> operationList = new List<int>();

        //    if (k > n)
        //    {
        //        return -1;
        //    }

        //    int index = n - k;

        //    for (int i = 0; i <= index; i++)
        //    {
        //        int count = 0;
        //        foreach (char x in blocks.Substring(i, k))
        //        {
        //            if (x == 'B')
        //            {
        //                count++;
        //            }
        //        }
        //        operationList.Add(count);
        //    }

        //    return k - operationList.Max();
        //}

        public static int MinimumRecolors(string blocks, int k)
        {
            int left = 0;
            int recolor = 0;
            int res = k;

            for (int right = 0; right < blocks.Length; right++)
            {
                if (blocks[right] == 'W')
                {
                    recolor++;
                }
                if (right - left + 1 == k)
                {
                    res = Math.Min(res, recolor);
                    if (blocks[left] == 'W')
                    {
                        recolor--;
                    }
                    left++;
                }
            }

            return res;
        }
    }
}
