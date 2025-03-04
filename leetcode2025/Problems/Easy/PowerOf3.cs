using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class PowerOf3
    {
        public static bool IsPowerOfThree(int n)
        {
            bool powerof3 = false;

            powerof3 = BackTrack(n, 0, powerof3);

            return powerof3;
        }

        private static bool BackTrack(int n, int power, bool powerof3)
        {
            if (n == Math.Pow(3, power))
            {
                return true;
            }
            else if (n > Math.Pow(3, power))
            {
                return BackTrack(n, power + 1, powerof3);
            }
            return false;
        }
    }
}
