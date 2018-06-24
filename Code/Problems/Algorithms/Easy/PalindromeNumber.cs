namespace Raw.LeetCode.Code.Problems.Algorithms.Easy
{
    using System;

    public class PalindromeNumber
    {
        public static bool Solution(int x)
        {
            return UsingInts(x);
        }

        private static bool UsingStrings(int x)
        {
            if (x < 0)
                return false;

            int reverese = RevereseInteger.Solution(x);
            return x == reverese;
        }

        private static bool UsingInts(int x)
        {
            bool result = x >= 0;

            int power = (int)Math.Log10(x);
            int loops = (power + 2) / 2;
            int i = 0;

            while (result && i < loops)
            {
                int frontEnd = (x / (int)Math.Pow(10, power - i)) % 10;
                int backEnd = (x / (int)Math.Pow(10, i)) % 10;
                result = frontEnd == backEnd;
                i++;
            }

            return result;
        }
    }
}
