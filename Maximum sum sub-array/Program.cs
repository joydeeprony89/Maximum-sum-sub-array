using System;

namespace Maximum_sum_sub_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine(MaxSubArray(nums));
        }

        static int MaxSubArray(int[] nums)
        {
            int currentMax = nums[0];
            int globalMax = nums[0];
            for(int i = 1; i< nums.Length; ++i)
            {
                currentMax = Math.Max(nums[i], nums[i] + currentMax);
                globalMax = Math.Max(currentMax, globalMax);
            }

            return globalMax;
        }
    }
}
