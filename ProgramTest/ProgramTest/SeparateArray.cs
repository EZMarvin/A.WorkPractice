using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest
{
    class SeparateArray
    {
        public void SeparateNegative(ref int[] nums)
        {
            int length = nums.Length;
            int pos = 0;
            int scan = 0;
            while (nums[pos] < 0)
            {
                pos++;
            }
            while (scan < length)
            {
                if (nums[scan] < 0)
                {
                    swap(ref nums, scan, pos);
                    pos = scan;
                }

            }
        }

        public void SeparateZeroOne(ref int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return;
            int start = 0;
            int end = nums.Length - 1;
            int scan = 0;
            while (nums[start] == 0)
                start++;
            while (nums[end] == 1)
                end--;
            while (start < end)
            {
                if (nums[start] == 1 && nums[end] == 0)
                {
                    swap(ref nums, start, end);
                    start++;
                    end--;
                }
                else
                {
                    while (nums[start] == 0)
                        start++;
                    while (nums[end] == 1)
                        end--;
                }
            }
        }
        public void swap(ref int[] nums, int i, int j)
        {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }
    }
}
