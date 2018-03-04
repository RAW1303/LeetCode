namespace Raw.LeetCode.Test.Problems.Algorithms.Easy
{
    using NUnit.Framework;
    using Code.Problems.Algorithms.Easy;


    [TestFixture]
    class ValidParanthesesTests
    {
        [TestCase("{[()]}", ExpectedResult = true)]
        public bool TestSolution(string s)
        {
            return ValidParentheses.Solution(s);
        }
    }
}
