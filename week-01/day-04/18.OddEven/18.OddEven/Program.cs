using System;

namespace _18.OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.

            Console.WriteLine("Hello, I am Poly Gon. I can tell even from odd. Try me, and give me a number! ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("That was easy, everyone knows that " + number + " is even");
            }
            else
            {
                Console.WriteLine("Wanted to be tricky, eh? But I know " + number + " is even. ");
            }

            Console.ReadLine();
        }
    }
}
