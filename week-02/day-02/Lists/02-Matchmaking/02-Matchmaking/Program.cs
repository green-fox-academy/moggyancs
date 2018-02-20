using System;
using System.Collections.Generic;
    

namespace _02_Matchmaking
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            Console.WriteLine(MakingMatches(girls, boys));
            Console.ReadLine();
        }

        static string MakingMatches(List<string> girls, List<string> boys)
        {
            string pairs = "";

            for (int i = 0; i < girls.Count; i++)
            {
                    pairs += girls[i] + " matched " + boys[i] + "\n";
            }

            return pairs;
        }
    }
}
