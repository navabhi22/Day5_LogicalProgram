using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class PrimeNumber
    {
        /// <summary>
        /// Checks for the PrimeNumber.
        /// </summary>
        /// <param name="N">The n.</param>
        public static void PrimeNum(int N)
        {
            int numOfFact = 0;
            for (int i = 1; i <= N; i++)
            {
                int rimainder = N % i;

                if (rimainder == 0)
                {
                    numOfFact++;
                }

            }

            if (numOfFact == 2)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
