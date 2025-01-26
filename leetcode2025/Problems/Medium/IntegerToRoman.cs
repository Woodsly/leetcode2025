using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Medium
{
    public static class IntegerToRoman
    {
        //https://leetcode.com/problems/integer-to-roman/

        public static string IntToRoman(int num)
        {
            string roman = "";
            int first;

            if (num >= 1000)
            {
                first = num / 1000;

                num = num - (first * 1000);

                while (first > 0)
                {
                    roman += "M";
                    first--;
                }
            }

            if (num >= 100)
            {
                first = num / 100;

                num = num - (first * 100);

                if (first == 9)
                {
                    roman += "CM";
                }
                else if (first == 4)
                {
                    roman += "CD";
                }
                else if (first == 5)
                {
                    roman += "D";
                }
                else if (first <= 3)
                {
                    int count = first;
                    while (count > 0)
                    {
                        roman += "C";
                        count--;
                    }
                }
                else if (first <= 8)
                {
                    int count = first - 5;
                    roman += "D";
                    while (count > 0)
                    {
                        roman += "C";
                        count--;
                    }
                }
            }

            if (num >= 10)
            {
                first = num / 10;

                num = num - (first * 10);

                if (first == 9)
                {
                    roman += "XC";
                }
                else if (first == 4)
                {
                    roman += "XL";
                }
                else if (first == 5)
                {
                    roman += "L";
                }
                else if (first <= 3)
                {
                    int count = first;
                    while (count > 0)
                    {
                        roman += "X";
                        count--;
                    }
                }
                else if (first <= 8)
                {
                    int count = first - 5;
                    roman += "L";
                    while (count > 0)
                    {
                        roman += "X";
                        count--;
                    }
                }
            }

            if (num >= 1)
            {
                first = num;

                if (first == 9)
                {
                    roman += "IX";
                }
                else if (first == 4)
                {
                    roman += "IV";
                }
                else if (first == 5)
                {
                    roman += "V";
                }
                else if (first <= 3)
                {
                    int count = first;
                    while (count > 0)
                    {
                        roman += "I";
                        count--;
                    }
                }
                else if (first <= 8)
                {
                    int count = first - 5;
                    roman += "V";
                    while (count > 0)
                    {
                        roman += "I";
                        count--;
                    }
                }
            }

            return roman;
        }
    }
}
