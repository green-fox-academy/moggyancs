using System;
using System.Collections.Generic;
using System.Text;

namespace Gardening
{
    class Tree : Plant
    {
        private double waterLevel;
        private string treeName;

        public Tree(string name) : base(name)
        {
            this.treeName = name;
            this.waterLevel = 0.0;
        }

    }
}
