using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that prints the multiplication table of a given base number.
            // It should take the base number as a parameter, and prints the output to the
            // console.

            // The output should look like this for 5 as base:
            //  1 * 5 = 5

            Console.WriteLine("Please add base number: ");
            int baseNumber = int.Parse(Console.ReadLine());
            Multiply(baseNumber);

            Console.ReadLine();
        }

        static void Multiply(int baseNumber)
        {
            Console.WriteLine($"The multiplication table for {baseNumber} is the following:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {baseNumber} = {i * baseNumber}");
            }
        }
    }
}
