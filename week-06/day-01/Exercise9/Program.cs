using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to convert a char array to a string!

            char[] characters = { 'a', ' ', 's', 't', 'r', 'i', 'n', 'g' };

            string s = string.Join("", characters);

            var CharsToStringMethod = String.Concat(characters);

            Console.WriteLine(s);
            Console.WriteLine(CharsToStringMethod);
            Console.ReadLine();
        }
    }
}
