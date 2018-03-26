using System;
using System.Linq;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the average value of the odd numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var oddAvgQuery = (from nums in n
                               where nums % 2 != 0
                               select nums)
                              .Average();

            Console.WriteLine(oddAvgQuery);


            var oddAvgMethod = n.Where(number => number % 2 != 0).Average();

            Console.WriteLine(oddAvgMethod);
        
            Console.Read();


        }
    }
}
