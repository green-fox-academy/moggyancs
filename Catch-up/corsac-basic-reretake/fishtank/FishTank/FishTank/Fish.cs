using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    abstract class Fish
    {
        string name;
        double weight;
        string color;

        public Fish(string name, int weight, string color)
        {
            this.name = name;
            this.weight = weight;
            this.color = color;
        }

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public string Color { get => color; set => color = value; }

        public virtual string Status()
        {
            return $"{Name}, weight: {Weight}, color: {Color}";
        }
        public abstract void Feed();
    }
}
