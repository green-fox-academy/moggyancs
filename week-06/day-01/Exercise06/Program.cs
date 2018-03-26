using System;
using System.Linq;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of characters in a given string!

            string target = "A rough-coated, dough-faced, thoughtful ploughman strode through the streets of Scarborough; after falling into a slough, he coughed and hiccoughed.";

            var charFrequencyQuery = from characters in target.ToCharArray()
                                     orderby characters
                                     group characters by characters;

            var charFrequencyMethod = target.GroupBy(chars => chars).OrderBy(chars => chars.Key);

            foreach (var character in charFrequencyQuery)
            {
                Console.WriteLine($"The character {character.Key} occurs {character.Count()} times in your string.");
            }

            Console.WriteLine();

            foreach (var character in charFrequencyMethod)
            {
                Console.WriteLine($"The character {character.Key} occurs {character.Count()} times in your string.");

            }

            Console.ReadLine();
        }
    }
}
