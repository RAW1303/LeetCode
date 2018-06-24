namespace Raw.LeetCode.Test.Problems.Algorithms.Easy
{
    using NUnit.Framework;
    using Code.Problems.Algorithms.Easy;

    [TestFixture]
    class PalindromeNumberTest
    {
        [TestCase(121, ExpectedResult = true, TestName = "Basic true")]
        [TestCase(10, ExpectedResult = false, TestName = "Basic false")]
        [TestCase(0, ExpectedResult = true, TestName = "Zero")]
        [TestCase(-121, ExpectedResult = false, TestName = "Negative")]
        [TestCase(int.MaxValue, ExpectedResult = false, TestName = "Max")]
        [TestCase(int.MinValue, ExpectedResult = false, TestName = "Min")]
        public bool TestSolution(int x)
        {
            return PalindromeNumber.Solution(x);
        }
    }
}
