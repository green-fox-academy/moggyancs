using System;

namespace _07.FavoriteNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Store your favorite number in a variable (as a number)
            // And print it like this: "My favorite number is: 8"

            Console.WriteLine("What is your favourite number? ");
            decimal favNr = decimal.Parse(Console.ReadLine());
            Console.WriteLine("So your favourite number is " + favNr);
            Console.ReadLine();
        }
    }
}
