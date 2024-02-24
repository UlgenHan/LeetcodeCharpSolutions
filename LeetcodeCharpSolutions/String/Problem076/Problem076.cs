using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeCharpSolutions.String.Problem076
{
    public class Problem076
    {
        public string MinWindow(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            {
                return "";
            }

            int[] targetCount = new int[128];

            foreach (char c in t)
            {
                targetCount[c]++;
            }

            int left = 0, right = 0;
            int minLen = int.MaxValue;
            int minStart = 0;
            int requiredChars = t.Length;

            while (right < s.Length)
            {
                if (targetCount[s[right++]]-- > 0)
                {
                    requiredChars--;
                }

                while (requiredChars == 0)
                {
                    if (right - left < minLen)
                    {
                        minLen = right - left;
                        minStart = left;
                    }

                    if (targetCount[s[left++]]++ == 0)
                    {
                        requiredChars++;
                    }
                }
            }

            return (minLen == int.MaxValue) ? "" : s.Substring(minStart, minLen);
        }
    }
}
