using System;

namespace _05.TwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints a few operations on two numbers: 22 and 13
            int numOne = 22;
            int numTwo = 13;
            // Print the result of 13 added to 22
            Console.WriteLine(numOne + numTwo);
            // Print the result of 13 substracted from 22
            Console.WriteLine(numOne - numTwo);
            // Print the result of 22 multiplied by 13
            Console.WriteLine(numOne * numTwo);
            // Print the result of 22 divided by 13 (as a decimal fraction)
            object result = (Decimal)numOne / (Decimal)numTwo;
            Console.WriteLine(result);
            // Print the integer part of 22 divided by 13
            Console.WriteLine(numOne / numTwo);
            // Print the reminder of 22 divided by 13
            Console.WriteLine(numOne % numTwo);
            Console.ReadLine();
        }
    }
}
