using System;

namespace _19.OneTwoALot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot

            Console.WriteLine("Hello, I am Polly Gon. I am 3. I cannot count too well, but I try my best. Please, give me a number! ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Nah, that is too small. It is not enough to count.");
            }

            else if (number == 1)
            {
                Console.WriteLine("That was one.");
            }

            else if (number == 2)
            {
                Console.WriteLine("That was two.");
            }

            else
            {
                Console.WriteLine("That's a lot. I cannot count that far.");
            }
            Console.ReadLine();
        }
    }
}
