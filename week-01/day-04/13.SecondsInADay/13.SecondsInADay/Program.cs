using System;

namespace _13.SecondsInADay
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables

            int gonetime = (currentHours * 60 * 60 + currentMinutes * 60 + currentSeconds);
            int timeleft = (24 * 60 * 60 - gonetime);

            Console.WriteLine("There are {0} seconds left for today.", timeleft);
            Console.ReadLine();


        }
    }
}
