using System;

namespace ParametricAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("How many numbers will there be?");
            int turns = int.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = 0; i < turns; i++)
            {
                Console.WriteLine($"Give me number #{i+1}");
                sum += int.Parse(Console.ReadLine());
            }

            double average = sum / turns;
            Console.WriteLine($"The average of your numbers is {average}");
            Console.ReadLine();
        }
    }
}
