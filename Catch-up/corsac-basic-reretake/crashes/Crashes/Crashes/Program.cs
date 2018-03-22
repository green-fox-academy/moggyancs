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
            string[] lines = ReadLines("./crash-incidents.csv");
            var weatherConditions = ParseWeatherConditions(lines);
            CountAccidents(weatherConditions);
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

        static void CountAccidents(List<string> weatherConditions)
        {
            var badWeatherConditions = new List<string>
            {
                "RAIN", "FREEZING RAIN", "SNOW", "FOG", "SEVERE CROSSWINDS"
            };

            var goodWeatherConditions = new List<string>
            {
                "CLOUDY", "CLEAR"
            };

            int badWeatherCount = CountWeatherCondition(weatherConditions, badWeatherConditions);
            int goodWeatherCount = CountWeatherCondition(weatherConditions, goodWeatherConditions);

            Console.WriteLine($"The amount of crashes at good weather conditions: {goodWeatherCount}");
            Console.WriteLine($"The amount of crashes at bad weather conditions: {badWeatherCount}");
        }

        static int CountWeatherCondition(List<string> weatherConditions, List<string> weatherConditionsToCount)
        {
            int weatherConditionCount = 0;

            foreach (var weatherCondition in weatherConditions)
            {
                if (weatherConditionsToCount.Contains(weatherCondition))
                {
                    weatherConditionCount++;
                }
            }

            return weatherConditionCount;
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