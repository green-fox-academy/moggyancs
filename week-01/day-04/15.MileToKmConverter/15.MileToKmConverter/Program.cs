using System;

namespace _15.MileToKmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
            Console.WriteLine("How many kilometers shall I convert to miles? ");
            int kms = int.Parse(Console.ReadLine());

            double miles = kms / 1.609344;

            Console.WriteLine(kms + " kilometers are " + miles + "  miles. ");

            Console.ReadLine();

        }
    }
}
