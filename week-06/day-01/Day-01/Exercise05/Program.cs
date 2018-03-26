using System;
using System.Linq;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of numbers in the following array:

            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var FrequencyQuery = from nums in n
                                 orderby nums
                                 group nums by nums;

            var FrequencyMethod = n.GroupBy(number => number).OrderBy(number => number.Key);

            foreach (var frNo in FrequencyQuery)
            {
                Console.WriteLine($"Number {frNo.Key} appears {frNo.Count()} times.");
            }

            Console.WriteLine();

            foreach (var number in FrequencyMethod)
            {
                Console.WriteLine($"Number {number.Key} appears {number.Count()} times.");

            }

            Console.ReadLine();
        }
    }
}
