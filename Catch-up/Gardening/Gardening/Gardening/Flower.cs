using System;
using System.Collections.Generic;
using System.Text;

namespace Gardening
{
    class Flower : Plant
    {
        public Flower(string color) : base(color)
        {
            criticalWaterLevel = 5;
            waterAbsorb = 0.75;
        }
    }
}
