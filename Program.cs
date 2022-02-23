using System;

namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day6_LogicalProgram");

            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            PrimeNumber.PrimeNum(num);



        }
    }
}