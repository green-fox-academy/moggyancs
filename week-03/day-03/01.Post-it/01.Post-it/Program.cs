using System;
using System.Drawing;

namespace _01.Post_it
{
    class Program
    {
        public struct Posts
        {
            public Color BackGroundColor;
            public string notes;
            public Color Textcolor;
        }
  
        static void Main(string[] args)
        {
            Posts post01 = new Posts();
            post01.BackGroundColor = Color.Orange;
            post01.notes = "Idea 1";
            post01.Textcolor = Color.Blue;

            Posts post02 = new Posts();
            post02.BackGroundColor = Color.Pink;
            post02.notes = "Awesome!";
            post02.Textcolor = Color.Black;

            Posts post03 = new Posts();
            post03.BackGroundColor = Color.Yellow;
            post03.notes = "Superb";
            post03.Textcolor = Color.Green;


        }
    }
}
