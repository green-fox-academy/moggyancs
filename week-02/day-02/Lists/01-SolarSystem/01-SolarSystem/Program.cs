using System;
using System.Collections.Generic;

namespace _01_SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
           
            // Saturn is missing from the planetList
            // Insert it into the correct position
            // Create a method called PutSaturn() which has list parameter and returns the correct list.

            Console.WriteLine(PutSaturn(planetList));
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", ** "Uranus", "Neptune", "Saturn"
            Console.ReadLine();
        }

        public static string PutSaturn(List<string> solar)
        {
            solar.Insert(5, "Saturn");
            string fullsolar = "";
            foreach (var item in solar)
            {
                fullsolar += "\"" + item + "\"" + ", ";
            }
            return fullsolar;
                    
        }

    }
}
