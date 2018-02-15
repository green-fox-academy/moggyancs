using System;

namespace _16.AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            Console.WriteLine("How many chickens does old Mc'Donald have? ");
            int chicken = int.Parse(Console.ReadLine());
            Console.WriteLine("How many pigs does old Mc'Donald have? ");
            int pigs = int.Parse(Console.ReadLine());

            int legs = chicken * 2 + pigs * 4;
            Console.WriteLine("Thats a quite a few animals, with a lot of legs. " + legs + ", to be more precise.");

            Console.ReadLine();
        }
    }
}
