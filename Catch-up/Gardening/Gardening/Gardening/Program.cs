using System;

namespace Gardening
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden MyGarden = new Garden();

            MyGarden.Add(new Flower("yellow"));
            MyGarden.Add(new Flower("blue"));
            MyGarden.Add(new Tree("purple"));
            MyGarden.Add(new Tree("orange"));
            MyGarden.ShowGarden();

            MyGarden.Irrigation(40);
            MyGarden.ShowGarden();

            MyGarden.Irrigation(70);
            MyGarden.ShowGarden();

            Console.ReadLine();
        }
    }
}
