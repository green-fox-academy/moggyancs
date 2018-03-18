using System;
using System.Collections.Generic;
using System.Text;

namespace Gardening 
{
    class Tree : Plant
    {
        public Tree(string color) : base(color)
        {
            waterAbsorb = 0.4;
            criticalWaterLevel = 10;
        }
    }
}
