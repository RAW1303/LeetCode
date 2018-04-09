using NUnit.Framework;
using Raw.LeetCode.Code.Problems.Algorithms.Medium;

namespace Raw.LeetCode.Test.Problems.Algorithms.Medium
{
    class LongestPalindromicSubstringTest
    {
        [TestCase("babad", new string[] { "bab", "aba" }, TestName = "Basic")]
        [TestCase("cbbd", new string[] { "bb" }, TestName = "Short")]
        public void TestSolution(string s, string[] valid)
        {
            Assert.Contains(LongestPalindromicSubstring.Solution(s), valid);
        }
    }
}
