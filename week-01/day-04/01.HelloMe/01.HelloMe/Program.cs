using System;

namespace _01.HelloMe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet you instead of the World!
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);

            Console.ReadLine();
        }
    }
}
