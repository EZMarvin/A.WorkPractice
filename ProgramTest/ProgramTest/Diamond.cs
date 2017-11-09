using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest
{
    class Diamond
    {
        public void PrintDiamond(int row)
        {
            int max = row * 2 - 1;
            for (int i = 0; i < max; i++)
            {
                if (i < row)
                {
                    for (int j = row + i; j > 0; j--)
                    {
                        if (j > row - 1 - i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = row + max - i; j > 0; j--)
                    {
                        if (j > row - 1 - i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}
