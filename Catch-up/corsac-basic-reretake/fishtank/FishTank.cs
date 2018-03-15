using System;

namespace FishTank
{
    public class FishTank
    {
        public static void Main(string[] args)
        {
            // There are 3 kind of fishes:
            // - Clownfish, gains 1 gramm when feeded and has stripe color.
            // - Tang, gains 1 gramms when feeded and can suffer short-term memory loss.
            // - Koi, gains 2 gramms when feeded.
            // Each fish has a name, weight, color and has a status and feed method.

            // Create an aquarium and take care of your fishes.
            // Create a method on the aquarium that feeds all the fishes in the aquarium:
            // increases the weight of every fish with the amount of gramms they gain when feeded.
            // Create a method on the aquarium that removes the big fishes.
            // A big fish's weight is at least 11 gramms.
            // The aquarium has a status method it should print the status for each fish.

            var aquarium = new Aquarium();

            aquarium.Add(new Koi("Nami", 9, "pink"));
            aquarium.Add(new Tang("Dory", 8, "blue", true));
            aquarium.Add(new Tang("Bubbles", 10, "yellow", false));
            aquarium.Add(new Clownfish("Nemo", 5, "orange", "white"));

            Console.WriteLine(aquarium.Status());

            // Nami, weight: 9, color: pink
            // Dory, weight: 8, color: blue, short-term memory loss: true
            // Bubbles, weight: 10, color: yellow, short-term memory loss: false
            // Nemo, weight: 5, color: orange, stripe color: white

            aquarium.Feed();
            aquarium.RemoveOversizedFishes();

            Console.WriteLine(aquarium.Status());

            // Dory, weight: 9, color: blue, short-term memory loss: true
            // Nemo, weight: 6, color: orange, stripe color: white
        }
    }
}
