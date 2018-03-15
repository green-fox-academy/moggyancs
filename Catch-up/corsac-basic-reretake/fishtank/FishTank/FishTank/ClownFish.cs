using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    class Clownfish : Fish
    {
        private string stripeColor;

        public Clownfish(string name, int weight, string color, string stripes) : base(name, weight, color)
        {
            stripeColor = stripes;
        }

        public override void Feed()
        {
            Weight++;
        }

        public override string Status()
        {
            return $"{Name}, weight: {Weight}, color {Color}, stripe color: {stripeColor}";
        }
    }
}
