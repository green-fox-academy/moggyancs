using System;
using System.IO;

namespace Crashes
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../../../crash-incidents.csv";
            WeatherCircumstance(path);
                
            Console.ReadLine();
        }

        static void WeatherCircumstance(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int goodAmount = 0;
            int badAmount = 0;
            foreach (string line in lines)
            {
                if (line.Contains("CLOUDY") || line.Contains("CLEAR"))
                {
                    goodAmount++;
                }
                else
                {
                    badAmount++;
                }
            }
            Console.WriteLine($"The amount of crashes at good weather conditions: {goodAmount}");
            Console.WriteLine($"The amount of crashes at bad weather conditions: {badAmount}");
        }
    }
}