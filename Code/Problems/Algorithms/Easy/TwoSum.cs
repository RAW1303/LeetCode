namespace Raw.LeetCode.Code.Problems.Algorithms.Easy
{ 
    using System;
    using System.Collections.Generic;

    public static class TwoSum
    {

        public static int[] Solution(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                int c = target - nums[i];
                if(map.ContainsKey(c))
                {
                    return new int[] { map[c], i };
                }

                map.TryAdd(nums[i], i);
            }

            throw new ArgumentException("No solution");
        }
    }
}
