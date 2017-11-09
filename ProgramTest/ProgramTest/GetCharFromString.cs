using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest
{
    class GetCharFromString
    {
        public char GetChar(String s, int index)
        {
            int length = s.Length;
            if (s == null || length == 0 || index <= 0)
                return ' ';

            index = index % length - 1;
            return s[index];
        }
    }
}
