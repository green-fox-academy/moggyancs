using System;
using System.Collections.Generic;
using System.Text;

namespace Gardening
{
    public class Plant
    {
        private double waterLevel;
        public string plantName;

        public Plant(string name)
        {
            this.plantName = name;
            this.waterLevel = 0.0;
        }

        public double GetWaterLvl()
        {
            return waterLevel;
        }

        public void SetWaterLvl(double water)
        {
            waterLevel += water;
        }
            
    }
}
