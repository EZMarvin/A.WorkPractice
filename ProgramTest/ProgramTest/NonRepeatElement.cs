using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest
{
    class NonRepeatElement
    {
        public ArrayList GetNonRepeat(int[] nums)
        {
            ArrayList result = new ArrayList();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            if (nums == null || nums.Length == 0)
                return result;

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                    dict[nums[i]]++;
                else
                    dict[nums[i]] = 1;
            }
            
            foreach (var item in dict)
            {
                if (item.Value == 1)
                    result.Add(item.Key);
            }
            return result;
        }
    }
}
