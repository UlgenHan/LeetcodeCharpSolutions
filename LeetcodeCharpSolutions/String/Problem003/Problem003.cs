using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeCharpSolutions.String.Problem003
{
    public class Problem003
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s == null || s.Length == 0) return 0;

            HashSet<char> characterMap = new HashSet<char>();
            int left = 0;
            int maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char currentCharacter = s[right];
                while (characterMap.Contains(currentCharacter))
                {
                    characterMap.Remove(s[left]);
                    left++;
                }
                characterMap.Add(currentCharacter);
                maxLength = Math.Max(maxLength, right - left + 1);
            }
            return maxLength;

        }
    }
}
