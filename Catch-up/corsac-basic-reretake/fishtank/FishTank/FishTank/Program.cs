using System;

namespace FishTank
{
    public class FishTank
    {
        public static void Main(string[] args)
        {
            var aquarium = new Aquarium();

            aquarium.Add(new Koi("Nami", 9, "pink"));
            aquarium.Add(new Tang("Dory", 8, "blue", true));
            aquarium.Add(new Tang("Bubbles", 10, "yellow", false));
            aquarium.Add(new Clownfish("Nemo", 5, "orange", "white"));

            Console.WriteLine(aquarium.Status());
            Console.WriteLine();

            aquarium.Feed();
            aquarium.RemoveOversizedFish();

            Console.WriteLine(aquarium.Status());
            Console.ReadLine();
        }
    }
}