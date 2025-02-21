using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class SqrtX
    {
        public static int MySqrt(int x)
        {
            int number = 0;

            for (int i = 1; i <= x; i++)
            {
                if (x / i >= i && x / (i + 1) < (i +1))
                {
                    return i;
                }
            }

            return number;
        }
    }
}
