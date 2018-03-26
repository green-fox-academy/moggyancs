using System;
using System.Linq;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:

            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            var bigSquareQuary = from nums in n
                                 where nums * nums > 20
                                 select nums;

            var bigSquareMethod = n.Where(number => number * number > 20).Select(number => number);

            foreach (var number in bigSquareQuary)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            foreach (var number in bigSquareMethod)
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();
        }
    }
}
