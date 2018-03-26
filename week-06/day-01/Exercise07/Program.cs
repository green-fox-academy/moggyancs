using System;
using System.Linq;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:

            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var stringSearchQuery = from words in cities
                                    where words.StartsWith("A") && words.EndsWith("I")
                                    select words;

            var stringSearchMethod = cities.Where(word => word.StartsWith("A") && word.EndsWith("I"));


            foreach (var word in stringSearchQuery)
            {
                Console.WriteLine(word);
            }

            foreach (var word in stringSearchMethod)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }
}
