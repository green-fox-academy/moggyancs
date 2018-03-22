using System;
using System.Collections.Generic;
using System.IO;

namespace Crashes
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "./crash-incidents.csv";
            WeatherCircumstance(path);

            //CA solution
            string[] lines = ReadLines(path);
            var weatherconditions = ParseWeatherConditions(lines);
            Console.ReadLine();
        }

        static string[] ReadLines(string path)
        {
            return File.ReadAllLines("./crash-incidents.csv");
        }

        static List<string> ParseWeatherConditions(string[] rawCrashIncidents)
        {
            List<string> weatherConditions = new List<string>();
            foreach (var line in rawCrashIncidents)
            {
                weatherConditions.Add(line.Split(';')[5]);
            }
            return weatherConditions;
        }

        public void CountAccidents(List<string> weatherCondition)
        {
            var badConditions = new List<string>
            {
                "RAIN", "FREEZING RAIN", "SNOW", "FOG", "SEVERE CROSSWINDS"
            };

            var goodWeather = new List<string>
            {
                "CLOUDY", "CLEAR"
            };

            int badConditionCount = 0;
            int goodConditionCount = 0;

            foreach (var condition in weatherCondition)
            {
                if (badConditions.Contains(condition))
                {
                    badConditionCount++;
                }

                else if (goodWeather.Contains(condition))
                {
                    goodConditionCount++;
                }
            }
            Console.WriteLine($"CA The amount of crashes at good weather conditions: {goodConditionCount}");
            Console.WriteLine($"CA The amount of crashes at bad weather conditions: {badConditionCount}");
        }

        // my solution
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