using System;
using System.Linq;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the uppercase characters in a string!

            string target = "theQuickBrownFoxJumpsOverTheLazyDog";

            var UpperCaseQuery = from chars in target
                                 where chars.Equals(Char.ToUpper(chars))
                                 group chars by chars;

            var UpperCaseMethod = target.
                                 Where(c => Char.IsUpper(c)).
                                 GroupBy(c => c);

            Console.WriteLine(UpperCaseQuery.Count());
            Console.WriteLine(UpperCaseMethod.Count());

            Console.ReadLine();
        }
    }
}
