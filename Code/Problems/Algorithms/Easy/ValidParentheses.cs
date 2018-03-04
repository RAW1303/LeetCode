namespace Raw.LeetCode.Code.Problems.Algorithms.Easy
{
    using System.Collections.Generic;

    public static class ValidParentheses
    {
        public static bool Solution(string s)
        {
            Stack<char> openingParentheses = new Stack<char>();
            Dictionary<char, char> parenthesesPairs = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            foreach (char c in s)
            {
                if(parenthesesPairs.ContainsKey(c))
                {
                    char lastOpening;
                    bool popped = openingParentheses.TryPop(out lastOpening);
                    if (!popped || lastOpening != parenthesesPairs[c])
                    {
                        return false;
                    }
                }
                else if (parenthesesPairs.ContainsValue(c))
                {
                    openingParentheses.Push(c);
                }
            }

            return openingParentheses.Count == 0;
        }
    }
}
