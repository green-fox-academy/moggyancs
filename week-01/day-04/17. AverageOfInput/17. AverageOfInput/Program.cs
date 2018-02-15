using System;

namespace _17._AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Please insert five numbers: ");
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());

            int sum = one + two + three + four + five;
            int avg = sum / 5;

            Console.WriteLine("The sum of the given numbers is " + sum + ", and their average is " + avg + ".");
            Console.ReadLine();
        }
    }
}
