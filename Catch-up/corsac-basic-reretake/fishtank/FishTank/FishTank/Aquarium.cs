using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    class Aquarium
    {
        private List<Fish> FishTank;

        public Aquarium()
        {
            FishTank = new List<Fish>();
        }

        internal string Status()
        {
            List<string> myStatus = new List<string>();
            foreach (var fish in FishTank)
            {
               myStatus.Add(fish.Status());
            }
            return string.Join("\n", myStatus);
        }

        internal void Add(Fish fish)
        {
            FishTank.Add(fish);
        }

        internal void Feed()
        {
            foreach (var fish in FishTank)
            {
                fish.Feed();
            }
        }

        internal void RemoveOversizedFish()
        {
            FishTank.RemoveAll(IsOverWeight);
        }  

        private static bool IsOverWeight(Fish fish)
        {
            return fish.Weight > 10;
        }
    }
}
