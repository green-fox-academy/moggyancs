using System;
using System.Collections.Generic;
using System.Text;

namespace Gardening
{
    class Flower : Plant
    {
        public Flower(string color) : base(color) { }

        public override void Watering(double waterAmount)
        {
            WaterLevel += waterAmount * 0.75;
        }

        public override string Status()
        {
            return ($"The {this.Colour} Flower" + (WaterLevel < 5 ? " needs water" : " does not need water"));
        }

        public override bool NeedsWater()
        {
            return WaterLevel <= 5;
        }
    }
}
