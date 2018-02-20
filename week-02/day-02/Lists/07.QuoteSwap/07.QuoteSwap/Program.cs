using System;
using System.Collections.Generic;

namespace _07.QuoteSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Create a method called QuoteSwap().

            // Also, print the sentence to the output with spaces in between.
            Console.WriteLine(QuoteSwap(list));
            Console.ReadLine();
            // Expected output: "What I cannot create I do not understand." 
        }
        static string QuoteSwap (List<string> parts)
        {
            string ordered = "";

            parts.Add(parts[5]);
            parts[5] = parts[2];
            parts[2] = parts[parts.Count-1];

            for (int i = 0; i < parts.Count-1; i++)
            {
                ordered += parts[i] + " ";
            }
            return ordered;
        }

    }
}
