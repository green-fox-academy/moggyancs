using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    abstract class Fish
    {
        private string name;
        private double weight;
        private string color;
        private double foodAmount;

        public double Weight { get => weight; }

        public Fish(string name, int weight, string color, double foodAmount)
        {
            this.name = name;
            this.weight = weight;
            this.color = color;
            this.foodAmount = foodAmount;
        }

        public virtual string Status()
        {
            return $"{name}, weight: {weight}, color: {color}";
        }

        public void Feed()
        {
            this.weight += foodAmount;
        }
    }
}
