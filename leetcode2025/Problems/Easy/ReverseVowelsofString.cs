using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Easy
{
    public static class ReverseVowelsofString
    {
        public static string ReverseVowels(string s)
        {
            char[] reversed = s.ToCharArray();
            int right = s.Length - 1;
            int left = 0;
            string[] vowels = new string[] { "a", "e", "i", "o", "u"};

            while (left < right)
            {
                if (vowels.Any(v => v == s[right].ToString().ToLower()) && vowels.Any(v => v == s[left].ToString().ToLower()))
                {
                    char templeft = s[left];
                    char tempright = s[right];

                    reversed[right] = templeft;
                    reversed[left] = tempright;
                    right--;
                    left++;
                }

                if (!vowels.Any(v => v == s[right].ToString().ToLower()))
                {
                    right--;
                }

                if (!vowels.Any(v => v == s[left].ToString().ToLower()))
                {
                    left++;
                }
                
            }

            string answer = new string(reversed);

            return answer;
        }
    }
}
