using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class PerfectNumber
    {
        /// <summary>
        /// Finds the perfect number.
        /// </summary>
        public static void FindPerfectNumber()
        {
            int n, i, sum;
            int mn, mx;
            Console.WriteLine("Find the perfect number with in the given range");
            Console.WriteLine("----------------------");
            Console.WriteLine("Input the starting range or number ");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the ending range or number ");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The perfect number with in the given range :");
            for (n = mn; n < mx ; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                {
                    Console.Write(" {0} ", n);
                }
            }
        
        }

    }
}
