using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Medium
{
    public static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            int number = 0;

            string numberString = x.ToString();

            if (!string.IsNullOrEmpty(numberString))
            {
                char first = numberString[0];
                if (first == '-')
                {
                    number = reverseThis(numberString, first);
                }
                else
                {
                    number = reverseThis(numberString);
                }
            }

            return number;
        }

        public static int reverseThis(string x, char negative = ' ')
        {
            string reversed = "";
            int answer = 0;
            if (!string.IsNullOrWhiteSpace(negative.ToString()))
            {
                for (int i = x.Length - 1; i >= 1; i--)
                {
                    reversed += x[i];
                    string result = "-" + reversed;
                    if (int.TryParse(result, out answer))
                    {

                    }
                }
            }
            else
            {
                for (int i = x.Length - 1; i >= 0; i--)
                {
                    reversed += x[i];
                    if (int.TryParse(reversed, out answer))
                    {

                    }
                }
            }

            return answer;
        }
    }
}
