using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourh")
            // ...
            //   Console.WriteLine("What shall I print for you? Name two things!");
            //   string textOne = Console.ReadLine();
            // string textTwo = Console.ReadLine();
            Printer("apple");
            Printer("apple", "pear");
            Printer("apple", "pear", "grapes");
            Console.ReadLine();
        }
        public static void Printer(params string[] messages)
        {
            foreach (var message in messages) 
            {
                Console.Write(message + " ");
            }
            Console.WriteLine();

        }
        
    }
}
