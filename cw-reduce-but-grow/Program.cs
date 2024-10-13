using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_reduce_but_grow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Given a non-empty array of integers, return the result of multiplying
             * the values together in or order e.g. [1,2,3,4] = 1 * 2 * 3 * 4 = 24
             */

            int[] nums = { 1, 2, 3, 4 };

            Console.WriteLine(Grow(nums));

            Console.ReadLine();
        }

        public static int Grow(int[] x)
        {
            int sum = 1;
            for (int i = 0; i < x.Length; i++)
            {
                sum *= x[i];
            }
            return sum;
        }
    }
}
