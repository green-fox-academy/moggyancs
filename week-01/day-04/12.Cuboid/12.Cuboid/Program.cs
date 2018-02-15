using System;

namespace _12.Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            Console.WriteLine("How wide is your cuboid? ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("How tall is your cuboid? ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("How long is your cuboid? ");
            int length = int.Parse(Console.ReadLine());

            int surfaceArea = 2 * (width * length + length * height + width * height);
            int volume = width * length * height;

            Console.WriteLine("the Surface Area is " + surfaceArea);
            Console.WriteLine("the Volume is " + volume);

            Console.ReadLine();
        }
    }
}
