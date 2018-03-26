using System;
using System.Linq;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the even numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbersFromQuery = from num in n
                                       where num % 2 == 0
                                       select num;

            foreach (var number in evenNumbersFromQuery)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            var evenNumbersFromMethod = n
                                        .Where(number => number % 2 == 0)
                                        .Select(number => number);

            foreach (var number in evenNumbersFromMethod)
            {
                Console.Write(number + " ");
            }

            Console.ReadLine();
        }
    }
}
