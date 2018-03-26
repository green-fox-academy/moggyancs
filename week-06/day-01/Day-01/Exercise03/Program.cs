using System;
using System.Linq;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var squarePositiveQuery = from nums in n
                                      where nums > 0
                                      select nums * nums;

            var squarePositiveMethod = n
                    .Where(number => number > 0)
                    .Select(number => number * number);

            foreach (var number in squarePositiveQuery)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            foreach (var number in squarePositiveMethod)
            {
                Console.Write(number + " ");
            }

            Console.ReadLine();

        }
    }
}
