using System;

namespace _30.DrawDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

            Console.WriteLine("How big is my diamond?");
            int height = int.Parse(Console.ReadLine());
            string stars = "*";

            for (int i = 0; i < height / 2; i++)
            {
                for (int k = 0; k < height / 2 - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i / height; j++)
                {
                    Console.Write(stars);
                }
                Console.WriteLine();
                stars += "**";
            }
            if (height % 2 == 1)
            {
                Console.WriteLine(stars);
            }
            for (int i = 0; i < height / 2; i++)
            {
                for (int k = 0; k <= i ; k++)
                {
                    Console.Write(" ");
                }
                stars = stars.Substring(2);
                for (int j = 0; j <= i / height; j++)
                {
                    Console.Write(stars);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
