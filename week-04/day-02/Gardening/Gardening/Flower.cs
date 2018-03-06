using System;
using System.Collections.Generic;
using System.Text;

namespace Gardening
{
    class Flower : Plant
    {
        private double waterLevel;
        private string flowerName;

        public Flower(string name) : base(name)
        {
            this.flowerName = name;
            this.waterLevel = 0.0;
        }

    }
}
