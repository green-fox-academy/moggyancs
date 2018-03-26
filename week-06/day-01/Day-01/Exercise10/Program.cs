using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Fox class with 3 properties(name, type, color) Fill a list with at least 5 foxes, 
            //it's up to you how you name/create them! Write a LINQ Expression to find the foxes with green color! 
            //Write a LINQ Expression to find the foxes with green color and pallida type!

            Fox one = new Fox("Nick Wilde", "macrotis", "green");
            Fox two = new Fox("Robin Hood", "pallida", "grey");
            Fox three = new Fox("Eevee", "corsac", "green");
            Fox four = new Fox("ninetails", "pallida", "green");
            Fox five = new Fox("swiper", "totoro", "white");

            List<Fox> cohort = new List<Fox> { one, two, three, four, five };

            var GreenFoxes = cohort.Where(fox => fox.Color.Equals("green"));
            var GreenAndPallida = GreenFoxes.Where(fox => fox.Type.Equals("pallida"));

            foreach (var fox in GreenFoxes)
            {
                Console.WriteLine($"{fox.Name} is a {fox.Color} {fox.Type} type fox");
            }

            Console.WriteLine();

            foreach (var fox in GreenAndPallida)
            {
                Console.WriteLine($"{fox.Name} is a {fox.Color} {fox.Type} type fox");
            }
            Console.ReadLine();

        }
    }
}
