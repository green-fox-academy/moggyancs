using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    class Tang : Fish
    {
        private bool memoryLoss;

        public Tang(string name, int weight, string color, bool memoryLoss) : base(name, weight, color, 1)
        {
            this.memoryLoss = memoryLoss;
        }

        public override string Status()
        {
            return base.Status() + $", short-term memory loss: {memoryLoss.ToString().ToLower()}";
        }
    }
}
