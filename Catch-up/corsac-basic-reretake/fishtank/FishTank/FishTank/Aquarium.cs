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

        public void Add(Fish fish)
        {
            this.FishTank.Add(fish);
        }

        public void Feed()
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

        internal string Status()
        {
            List<string> fishStatuses = new List<string>();
            foreach (var fish in FishTank)
            {
               fishStatuses.Add(fish.Status());
            }
            return string.Join("\n", fishStatuses) + "\n";
        }
    }
}
