using System;
using System.Collections.Generic;
using System.Text;

namespace Gardening
{
    class Garden
    {
        List<Plant> MyGarden = new List<Plant>();

        public void Add(Plant plant)
        {
            MyGarden.Add(plant);
        }

        public void Irrigation (double WaterAmount)
        { 
            Console.WriteLine($"Watering with {WaterAmount} \n");
            List<Plant> WillGetWater = new List<Plant>();

            foreach (var plant in MyGarden)
            {
                if (plant.NeedsWater())
                {
                WillGetWater.Add(plant);
                }
            }

            foreach (var plant in WillGetWater)
            {
                plant.Watering(WaterAmount / WillGetWater.Count);
            }
        }

        public bool DoesItNeedWater(Plant plant)
        {
            return plant.NeedsWater();
        }

        public void ShowGarden()
        {
            foreach (var plant in MyGarden)
            {
                Console.WriteLine(plant.Status());
            }
            Console.WriteLine();
        }
    }
}
