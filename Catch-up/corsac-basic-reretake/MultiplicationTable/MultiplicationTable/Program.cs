using System;
using System.IO;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add base number: ");
            int baseNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Multiply(baseNumber));

            Console.ReadLine();
        }

        static string Multiply(int baseNumber)
        {
            string table = $"The multiplication table for {baseNumber} is the following:";
            for (int i = 1; i <= 10; i++)
            {
                table += $"{i} * {baseNumber} = {i * baseNumber} \n";
            }
            return table;
        }
    }
}
