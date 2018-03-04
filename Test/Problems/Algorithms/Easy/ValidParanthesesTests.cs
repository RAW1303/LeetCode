namespace Raw.LeetCode.Test.Problems.Algorithms.Easy
{
    using NUnit.Framework;
    using Code.Problems.Algorithms.Easy;


    [TestFixture]
    class ValidParanthesesTests
    {
        [TestCase("()", ExpectedResult = true, TestName = "Basic")]
        [TestCase("{[()]}", ExpectedResult = true, TestName = "Nested")]
        [TestCase("()[]{}", ExpectedResult = true, TestName = "Sequence")]
        [TestCase("(]", ExpectedResult = false, TestName = "Wrong closing")]
        [TestCase("([)]", ExpectedResult = false, TestName = "Wrong order")]
        [TestCase("()[]{}]", ExpectedResult = false, TestName = "Too many closing")]
        [TestCase("()[]{", ExpectedResult = false, TestName = "Too few closing")]
        public bool TestSolution(string s)
        {
            return ValidParentheses.Solution(s);
        }
    }
}
