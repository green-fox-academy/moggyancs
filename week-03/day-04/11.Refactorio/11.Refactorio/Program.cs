using System;

namespace _11.Refactorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a recursive function called `refactorio`
            // that returns it's input's factorial

            int number = 5;
            Console.WriteLine(Factorial(number));
            Console.ReadLine();

        }

        static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
