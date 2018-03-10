namespace Raw.LeetCode.Test.Problems.Algorithms.Medium
{
    using NUnit.Framework;
    using Code.Problems.Algorithms.Medium;

    [TestFixture]
    class ZigZagConversionTest
    {
        [TestCase("PAYPALISHIRING", 3, ExpectedResult = "PAHNAPLSIIGYIR", TestName = "Basic")]
        [TestCase("0123456789", 1, ExpectedResult = "0123456789", TestName = "1 Row")]
        [TestCase("0123456789", 2, ExpectedResult = "0246813579", TestName = "2 Rows")]
        [TestCase("0123456789", 3, ExpectedResult = "0481357926", TestName = "3 Rows")]
        [TestCase("0123456789", 4, ExpectedResult = "0615724839", TestName = "4 Rows")]
        public string TestSolution(string s, int rows)
        {
            return ZigZagConversion.Solution(s, rows);
        }
    }
}
