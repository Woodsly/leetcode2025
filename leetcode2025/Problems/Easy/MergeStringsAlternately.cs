using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class MergeStringsAlternately
    {
        public static string MergeAlternately(string word1, string word2)
        {
            string merged = "";
            int count1 = word1.Length;
            int count2 = word2.Length;

            if (count1 == count2)
            {
                for (int i = 0; i < count1; i++)
                {
                    merged += word1[i];
                    merged += word2[i];
                }
            }
            else if (count1 > count2)
            {
                for (int i = 0; i < count2; i++)
                {
                    merged += word1[i];
                    merged += word2[i];
                }

                merged += word1.Substring(count2);
            }
            else
            {
                for (int i = 0; i < count1; i++)
                {
                    merged += word1[i];
                    merged += word2[i];
                }

                merged += word2.Substring(count1);
            }

            return merged;
        }
    }
}
