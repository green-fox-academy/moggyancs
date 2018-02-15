using System;

namespace _20.PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            Console.WriteLine("Hello, I am Polly Gon. If you give me two different numbers, I can tell, which one is bigger.");
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());

            if (one < two)
            {
                Console.WriteLine(two + " is bigger than " + one);
            }
            else if (one > two)
            {
                Console.WriteLine(one + " is bigger than " + two);
            }
            else 
            {
                Console.WriteLine("I said, two DIFFERENT numbers, silly.");
            }

           
            Console.ReadLine();
        }
    }
}
