using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class CanPlaceFlower
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int plantedFlowers = 0;

            if (flowerbed.Length == 1 && flowerbed[0] == 0 && (n == 1 || n == 0))
            {
                return true;
            }

            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0 && (i != 0 && i != flowerbed.Length - 1))
                {
                    if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                    {
                        flowerbed[i] = 1;
                        plantedFlowers++;
                    }
                }
                else if (flowerbed[i] == 0 && i == 0)
                {
                    if (flowerbed[i + 1] == 0)
                    {
                        flowerbed[i] = 1;
                        plantedFlowers++;
                    }
                }
                else if (flowerbed[i] == 0 && i == flowerbed.Length - 1)
                {
                    if (flowerbed[i - 1] == 0)
                    {
                        flowerbed[i] = 1;
                        plantedFlowers++;
                    }
                }
            }

            return plantedFlowers >= n;
        }
    }
}
