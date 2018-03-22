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

        public Fish(string name, int weight, string color, double foodAmount)
        {
            this.name = name;
            this.weight = weight;
            this.color = color;
            this.foodAmount = foodAmount;
        }

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public string Color { get => color; set => color = value; }

        public virtual string Status()
        {
            return $"{Name}, weight: {Weight}, color: {Color}";
        }

        public void Feed()
        {
            this.weight += foodAmount;
        }
    }
}
