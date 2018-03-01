using System;

namespace _05.Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).

            int n = 7;
            Console.WriteLine(CountBunnyEars(n));
            Console.ReadLine();
        }

        static int CountBunnyEars(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            else
            {
                return  2 + CountBunnyEars(n - 1);
            }
        }

    }
}
