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

            for (int i = 0; i < height/2; i++)
            {
                for (int k = height - i; k > 1; k--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < height / 2; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();

                for (int k = height - i; k > 1; k--)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

            }





            Console.ReadLine();
            {

            }
        }
    }
}
