using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    class Tang : Fish
    {
        private bool memoryLoss;

        public Tang(string name, int weight, string color, bool memoryLoss) : base(name, weight, color)
        {
            this.memoryLoss = memoryLoss;
        }

        public override void Feed()
        {
            Weight++;
        }

        public override string Status()
        {
            return $"{Name}, weight: {Weight}, color {Color}, short-term memory loss: {memoryLoss}";
        }
    }
}
