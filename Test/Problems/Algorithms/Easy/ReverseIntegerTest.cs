namespace Raw.LeetCode.Test.Problems.Algorithms.Easy
{
    using NUnit.Framework;
    using Code.Problems.Algorithms.Easy;

    [TestFixture]
    class ReverseIntegerTest
    {
        [TestCase(123, ExpectedResult = 321, TestName = "Basic")]
        [TestCase(-123, ExpectedResult = -321, TestName = "BasicNegative")]
        [TestCase(120, ExpectedResult = 21, TestName = "LeadingZero")]
        [TestCase(2147483647, ExpectedResult = 0, TestName = "PositiveOverflow")]
        [TestCase(-2147483645, ExpectedResult = 0, TestName = "NegativeOverflow")]
        public int TestSolution(int x)
        {
            return RevereseInteger.Solution(x);
        }
    }
}
