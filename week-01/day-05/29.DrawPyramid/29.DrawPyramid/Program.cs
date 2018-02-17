using System;

namespace _29.DrawPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
            Console.WriteLine("How tall is my pyramid?");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int k = height - i; k > 1; k--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");

                for (int j = 1; j <= i; j++ )
                    {
                        Console.Write("**");
                    }                
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        
    }
}
