﻿using System;

namespace _26.CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5


            Console.WriteLine("I can count from a small number to a bigger one. Give me two numbers!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
                                    
            if ( b - a > 0)
            {
                for (int i = a; i < b; i++)
                {
                    Console.WriteLine("\t" + a++);
                }
            }

            else
            {
                Console.WriteLine("The second number should be bigger!");
            }
            Console.ReadLine();
        }
    }
}
