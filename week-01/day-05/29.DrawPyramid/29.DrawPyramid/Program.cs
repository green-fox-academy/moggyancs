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
            string stars = "*";

            for (int i = 0; i < height; i++)
            {
                for (int k = height - i; k > 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i / height; j++ )
                {
                    Console.Write(stars);
                }                
                Console.WriteLine();
                stars += "**";
            }
            Console.ReadLine();
        }
        
    }
}
