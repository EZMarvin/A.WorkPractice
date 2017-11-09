using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest
{
    class TwoSum
    {
        public ArrayList TwoSumUse(int[] nums, int target)
        {
            ArrayList result = new ArrayList();
            if (nums == null || nums.Length == 0)
                return result;

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                    result.Add(new int[2]{ nums[dict[target - nums[i]]], nums[i] });
                dict[nums[i]] = i;
            }

            return result;
        }
    }
}
