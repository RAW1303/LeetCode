using System.Collections.Generic;
using System.Text;

namespace Raw.LeetCode.Code.Problems.Algorithms.Medium
{
    public static class ZigZagConversion
    {
        public static string Solution(string s, int numRows)
        {
            StringBuilder[] rows = new StringBuilder[numRows];
            
            int direction = 1;
            int nextRow = 0;

            foreach(char c in s)
            {
                if(rows[nextRow] == null)
                {
                    rows[nextRow] = new StringBuilder(c.ToString());
                }
                else
                {
                    rows[nextRow].Append(c);
                }

                if(numRows > 1)
                    nextRow += direction;

                if (nextRow == 0 || nextRow == numRows - 1)
                    direction = direction * -1;
            }

            for (int i = 1; i < numRows; i++)
            {
                rows[0].Append(rows[i]);
            }

            return rows[0].ToString();
        }
    }
}
