using System;
using System.Collections.Generic;
using System.Text;

namespace Raw.LeetCode.Code.Problems.Algorithms.Medium
{
    public class LongestPalindromicSubstring
    {
        public static string Solution(string s)
        {
            int start = 0, length = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i);
                int len2 = ExpandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > length)
                {
                    start = i - (len - 1) / 2;
                    length = len;
                }
            }
            return s.Substring(start, length);
        }

        private static int ExpandAroundCenter(String s, int left, int right)
        {
            int L = left, R = right;
            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            return R - L - 1;
        }
    }
}
