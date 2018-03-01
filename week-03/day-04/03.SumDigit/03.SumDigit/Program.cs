using System;

namespace _03.SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).

            int n = 1457923784;

            Console.WriteLine(SumDigits(n));
            Console.ReadLine();
        }

        public static int SumDigits( int n)
        {
            if (n == 0)
            {
                return n;
            }
            else
            {
                return n % 10 + SumDigits(n/10);
            }

        }
    }
}
