namespace Raw.LeetCode.Code.Problems.Algorithms.Easy
{
    using System;

    public static class RevereseInteger
    {
        public static int Solution(int x)
        {
            int result = 0;
            string xString = x.ToString();
            char[] resultString = new char[xString.Length];
            int currentIndex = xString.Length - 1;
            foreach(char c in xString)
            {
                if(c == '-')
                {
                    resultString[0] = c;
                }
                else
                {
                    resultString[currentIndex--] = c;
                }
            }

            int.TryParse(new string(resultString), out result);

            return result;
        }
    }
}
