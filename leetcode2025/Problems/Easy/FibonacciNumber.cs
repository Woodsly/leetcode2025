using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class FibonacciNumber
    {
        public static int Fib(int n)
        {
            if (n == 0) return 0;

            int[] data = new int[n + 1];
            data[0] = 0;
            data[1] = 1;

            for (int interval = 2; interval <= n; interval++)
            {
                data[interval] = data[interval - 1] + data[interval - 2];
            }

            return data[n];
        }
    }
}
