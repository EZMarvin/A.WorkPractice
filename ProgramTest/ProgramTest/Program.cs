using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            TwoSum twosum = new TwoSum();
            SeparateArray sep = new SeparateArray();
            NonRepeatElement non = new NonRepeatElement();

            //ArrayList array = new ArrayList();
            //array = twosum.TwoSumUse(new int[] { 1, 2, 3, 4, 5, 6 }, 8);
            //foreach (int[] i in array)
            //{
            //    foreach(int j in i)
            //        Console.Write(j + " ");
            //    Console.WriteLine(" ");
            //}


            //int[] nums = { 1, 0, 1, 0, 0, 1, 0 };
            //sep.SeparateZeroOne(ref nums);
            //foreach (int i in nums)
            //    Console.Write(i + " ");


            //int[] nums = { 1, 1, 2, 2, 3, 4, 4, 5 };
            //ArrayList list = non.GetNonRepeat(nums);
            //foreach(int i in list)
            //{
            //    Console.Write(i + " ");
            //}

            Diamond d = new Diamond();
            d.PrintDiamond(3);
            Console.Read();
        }
    }
}
