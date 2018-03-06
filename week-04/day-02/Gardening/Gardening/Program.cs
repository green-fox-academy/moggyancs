using System;
using System.Collections.Generic;

namespace Gardening
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden MyGarden = new Garden("My Garden");
            MyGarden.AddPlant(new Flower("Yellow flower"));
            MyGarden.AddPlant(new Flower("Blue flower"));
            MyGarden.AddPlant(new Tree("Purple tree"));
            MyGarden.AddPlant(new Tree("Orange tree"));

            MyGarden.Show();
            Console.WriteLine();

            MyGarden.Watering(40);
            Console.WriteLine();

            //MyGarden.Watering(75);
            //MyGarden.Show();

            Console.ReadLine();


        }
    }
}
