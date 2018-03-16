using System;
using System.Collections.Generic;
using System.Text;

namespace Gardening
{
    abstract class Plant
    {
        string colour;
        double waterLevel;

        protected Plant(string color)
        {
            this.colour = color;
            this.waterLevel = 0.0;
        }

        public string Colour { get => colour; set => colour = value; }
        public double WaterLevel { get => waterLevel; set => waterLevel = value; }

        public virtual void Watering(double waterAmount) { }
        public abstract bool NeedsWater();
        public abstract string Status();
    }
}
