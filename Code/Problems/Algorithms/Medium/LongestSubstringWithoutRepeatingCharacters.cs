namespace Raw.LeetCode.Code.Problems.Algorithms.Medium
{
    using System;
    using System.Collections.Generic;

    public static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int Solution(string s)
        {
            int length = s.Length;
            IDictionary<char, int> characters = new Dictionary<char, int>();

            int answer = 0, start = 0, end = 0;

            while (end < length)
            {
                if (characters.ContainsKey(s[end]))
                {
                    start = Math.Max(start, characters[s[end]]);
                }
                answer = Math.Max(answer, end - start + 1);
                characters[s[end]] = end + 1;
                end++;
            }

            return answer;
        }
    }
}
