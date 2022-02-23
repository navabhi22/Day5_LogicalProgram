using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class CouponNumber
    {
        /// <summary>
        /// Finds the new coupon number.
        /// </summary>
        public static void FindCouponNumber()
        {
            Random random = new Random();
            Console.WriteLine("Enter value of N to generate N random COUPON NUMBERS");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] Coupons = new int[N];
            for (int i = 0; i < Coupons.Length; i++)
            {
                Coupons[i] = random.Next(1000, 9999);
                Console.WriteLine(Coupons[i]);
            }

            int flag = 0;
            int RandomNumber = random.Next(1000, 9999);
            for (int i = 0;i < N;i++)
            {
               if (Coupons[i] == RandomNumber)
                {
                    flag = flag + 1;
                }
            }
            
            if (flag == 0)
            {
                Console.WriteLine("The Randome Number genrated is  not equal to any Coupon Number");
            }
            else if (flag > 0)
            {
                Console.WriteLine("The Randome Number genrated is equal to Coupon Number");
            }
            
        }
    }
}
