using System;

namespace _28.DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            Console.WriteLine("How tall is my pyramid?");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {                
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");                    
                }     
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
