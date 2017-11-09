using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest
{
    class Number
    {
        public int NumberReverse(int number)
        {
            int result = 0;
            int flag = number < 0 ? -1 : 1;

            number = Math.Abs(number);
            while (number > 0)
            {
                result = number % 10 + result * 10;
                number = number / 10;
            }
            return flag * result;
        }

        public int NumberChange(int number)
        {
            int result = 0;
            int flag = number < 0 ? -1 : 1;

            int length = Convert.ToInt32(Math.Log10(number)) + 1;
            int times = length / 2;

            int level = Convert.ToInt32(Math.Pow(10, length - 1));

            for (int i = 0; i < times; i++)
            {
                int high = number / level;
                number = number % level;
                level = level / 100;
                result = result * 10 + high;

                int low = number % 10;
                number = number / 10;
                result = result * 10 + low;
            }

            if (number != 0)
            {
                result = result * 10 + number;
            }

            return flag * result;
        }

    }
}
