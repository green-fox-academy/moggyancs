using System;

namespace Gardening
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden Eden = new Garden();

            Eden.AddPlant(new Flower("yellow"));
            Eden.AddPlant(new Flower("blue"));
            Eden.AddPlant(new Tree("purple"));
            Eden.AddPlant(new Tree("orange"));
            Eden.ShowGarden();

            Eden.Irrigation(40);
            Eden.ShowGarden();

            Eden.Irrigation(70);
            Eden.ShowGarden();

            Console.ReadLine();
        }
    }
}
