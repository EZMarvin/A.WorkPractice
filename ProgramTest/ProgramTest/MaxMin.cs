using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest
{
    class MaxMin
    {
        public int? GetMin(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;
            int min = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                min = Math.Min(nums[i], min);
            }
            return min;

        }
        public int? GetMax(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;
            int max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                max = Math.Max(nums[i], max);
            }
            return max;
        }
    }
}
