using System;
using System.Collections.Generic;
using System.Text;

namespace Gardening 
{
    class Tree : Plant
    {
        public Tree(string color) : base(color) { }

        public override void Watering(double waterAmount)
        {
            WaterLevel += waterAmount * 0.4;
        }

        public override string Status()
        {
            return ($"The {this.Colour} Tree" + (WaterLevel < 10 ? " needs water" : " does not need water"));
        }

        public override bool NeedsWater()
        {
            return WaterLevel <= 10;
        }
    }
}
