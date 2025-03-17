using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2025.Problems.Medium
{
    public static class ReverserWordsInString
    {
        public static string ReverseWords(string s)
        {
            string trim = s.Trim();
            char[] trimArray = trim.ToCharArray();
            string reversed = "";

            int left = trimArray.Length - 1;
            int right = trimArray.Length - 1;

            while (left >= 0)
            {
                if (string.IsNullOrEmpty(trimArray[left].ToString()))
                {
                    left--;
                }

                if (left != 0)
                {
                    if (!string.IsNullOrWhiteSpace(trimArray[left].ToString()) && string.IsNullOrWhiteSpace(trimArray[left - 1].ToString()))
                    {
                        if (right != trimArray.Length - 1)
                        {
                            reversed += " " + new string(trimArray).Substring(left, right - left + 1);
                            right = left;
                            left--;
                        }
                        else
                        {
                            reversed += new string(trimArray).Substring(left, right - left + 1);
                            right = left;
                            left--;
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(trimArray[left].ToString()) && !string.IsNullOrWhiteSpace(trimArray[left - 1].ToString()))
                    {
                        left--;
                    }
                    else if (string.IsNullOrWhiteSpace(trimArray[left].ToString()) && string.IsNullOrWhiteSpace(trimArray[left - 1].ToString()))
                    {
                        left--;
                    }
                    else if (string.IsNullOrWhiteSpace(trimArray[left].ToString()) && !string.IsNullOrWhiteSpace(trimArray[left - 1].ToString()))
                    {
                        right = left - 1;
                        left--;
                    }

                }
                else
                {
                    if (reversed == "")
                    {
                        reversed += new string(trimArray).Substring(left, right - left + 1);
                        right = left;
                        left--;
                    }
                    else
                    {
                        reversed += " " + new string(trimArray).Substring(left, right - left + 1);
                        right = left;
                        left--;
                    }
                }

            }

            return reversed;
        }
    }
}
