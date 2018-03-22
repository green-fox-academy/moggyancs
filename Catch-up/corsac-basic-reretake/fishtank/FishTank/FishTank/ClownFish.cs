using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    class Clownfish : Fish
    {
        private string stripeColor;

        public Clownfish(string name, int weight, string color, string stripeColor) : base(name, weight, color, 1)
        {
            this.stripeColor = stripeColor;
        }

        public override string Status()
        {
            return base.Status() + $", stripe color: {stripeColor}";
        }
    }
}
