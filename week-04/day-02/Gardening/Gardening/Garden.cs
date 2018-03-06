using System;
using System.Collections.Generic;
using System.Text;

namespace Gardening
{
    internal class Garden
    {
        string gardenName;
        List<Plant> plantsOfGarden = new List<Plant>();

        public Garden(string name)
        {
            this.gardenName = name;
        }

        public void Watering(double amountOfWater)
        {
            List<Plant> plantsToWater = new List<Plant>();
            foreach (var plant in plantsOfGarden)
            {
                if (CheckWaterLvl(plant))
                {
                    plantsToWater.Add(plant);
                }

                Console.WriteLine("You are watering your garden with {0} litres of water.", amountOfWater);
                plant.SetWaterLvl(amountOfWater / plantsToWater.Count);
            }
        }

        private bool CheckWaterLvl(Plant plants)
        {
                if (plants is Flower && plants.GetWaterLvl() <= 5)
                {
                    Console.WriteLine(plants.plantName + " needs watering.");
                    return true;
                }
                else if (plants is Tree && plants.GetWaterLvl() <= 10)
                {
                    Console.WriteLine(plants.plantName + " needs watering.");
                    return true;
                }
                else
                {
                    Console.WriteLine(plants.plantName + " does not need watering.");
                    return false;
                    
                }
        }

        public void Show()
        {
            foreach (var plant in plantsOfGarden)
            {
            CheckWaterLvl(plant);
            }
        }

        internal void AddPlant(Plant plant)
        {
            plantsOfGarden.Add(plant);
        }


    }
}
