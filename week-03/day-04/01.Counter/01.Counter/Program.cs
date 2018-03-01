using System;

namespace _01.Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and counts down from n.
            Console.WriteLine(CountDown(10));
            Console.Read();
        }

        public static int CountDown(int n)
        {
            if (n == 0)
            {
                return n;
            }
            else
            {
                Console.WriteLine(n);
                return CountDown( n - 1 );
            }
        }
    }
}
