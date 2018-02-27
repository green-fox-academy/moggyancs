using System;
using System.Collections.Generic;
using System.Drawing;

namespace _0_Trees
{
    public class Tree
    {
        public string Name { get; set; }
        public Color Leaf { get; set; }
        public int Age { get; set; }
        public bool Male { get; set; }
        public Tree(string name, Color leaf, int age, bool male)
        {
            Name = name;
            Leaf = leaf;
            Age = age;
            Male = male;
        }
        
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree1 = new Tree("Willow", Color.Blue, 5, false);
            Tree tree2 = new Tree("Elder", Color.Green, 3, true);
            Tree tree3 = new Tree("Maple", Color.Yellow, 6, false);
            Tree tree4 = new Tree("Populus negra", Color.Black, 9, false);
            Tree tree5 = new Tree("Cinnamon", Color.SaddleBrown, 1, true);

            Dictionary<string, Tree> myTreeFarm = new Dictionary<string, Tree>();
            myTreeFarm.Add("Willow", tree1);
            myTreeFarm.Add("Elder", tree2);
            myTreeFarm.Add("Maple", tree3);
            myTreeFarm.Add("Pupulus negra", tree4);
            myTreeFarm.Add("Cinnamon", tree5);


            foreach (Tree tree in myTreeFarm.Values)
            {
                Console.WriteLine("tree name: {0}, Leaves color: {1}, Age: {2}, is it male: {3},", 
                    tree.Name, tree.Leaf, tree.Age, tree.Male);
            }

            Console.ReadLine();


        }
    }
}
