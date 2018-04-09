using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Raw.LeetCode.Code.Problems.Algorithms.Easy;

namespace Raw.LeetCode.Test.Problems.Algorithms.Easy
{
    class SubdomainVisitCountTest
    {
        [TestCase(new string[] { "9001 discuss.leetcode.com" }, new string[] { "9001 discuss.leetcode.com", "9001 leetcode.com", "9001 com" }, TestName = "Basic")]
        [TestCase(new string[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" }, new string[] { "901 mail.com", "50 yahoo.com", "900 google.mail.com", "5 wiki.org", "5 org", "1 intel.mail.com", "951 com" }, TestName = "Second")]
        public void TestSolution(string[] cpdomains, IList<string> expectedArray)
        {
            IList<string> actual = SubdomainVisitCount.Solution(cpdomains);
            actual = actual.OrderBy(o => o).ToList();
            IList<string> expected = expectedArray.OrderBy(o => o).ToList();
            
            Assert.AreEqual(expected, actual); 
        }
    }
}
