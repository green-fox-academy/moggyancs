using System;
using System.Collections.Generic;
using System.Text;

namespace Gardening
{
    abstract class Plant
    {
        protected string colour;
        protected double waterLevel;
        protected double waterAbsorb;
        protected double criticalWaterLevel;

        protected Plant(string color)
        {
            this.colour = color;
            this.waterLevel = 0.0;
        }

        public string Colour { get => colour; set => colour = value; }
        public double WaterLevel { get => waterLevel; set => waterLevel = value; }

        public virtual void Watering(double waterAmount)
        {
            WaterLevel += waterAmount * waterAbsorb;
        }

        public bool NeedsWater()
        {
            return WaterLevel <= criticalWaterLevel;
        }

        public string Status()
        {
            return ($"The {Colour} Tree" + (NeedsWater() ? " needs water" : " does not need water") + WaterLevel);
        }
    }
}
