using System;

namespace _04.IntroduceYourself
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints a few details to the terminal window about you
            // It should print each detail to a new line.
            //  - Your name
            //  - Your age
            //  - Your height in meters (as a decimal fraction)
            //
            //  Example output:
            //  John Doe
            //  31
            //  1.87

            Console.WriteLine("Hi! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("And how old are you? ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("How tall are you (in m)? ");
            decimal height = decimal.Parse(Console.ReadLine());

            Console.WriteLine("So your name is {0}, you are {1} years old, and {2} meters tall. That is awesome!", name, age, height);

            Console.ReadLine();
         
        }
    }
}
