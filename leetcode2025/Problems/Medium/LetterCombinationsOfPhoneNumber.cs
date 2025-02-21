using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Medium
{
    public static class LetterCombinationsOfPhoneNumber
    {
        private static readonly Dictionary<string, string> keyboard = new Dictionary<string, string>
            {
                { "2", "abc" },
                { "3", "def" },
                { "4", "ghi" },
                { "5", "jkl" },
                { "6", "mno" },
                { "7", "pqrs" },
                { "8", "tuv" },
                { "9", "wxyz" }
            };

        public static IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();

            if (string.IsNullOrEmpty(digits))
            {
                return result;
            }

            BackTrack(result, "", digits, 0);

            return result;
        }

        private static void BackTrack(IList<string> result, string digitCombo, string digits, int index)
        {
            if (digitCombo.Length == digits.Length)
            {
                result.Add(new string(digitCombo));
                return;
            }

            string chars = keyboard[digits[index].ToString()];
            for (int i = 0; i < chars.Length; i++)
            {
                BackTrack(result, digitCombo + chars[i], digits, index + 1);
            }
        }
    }
}
