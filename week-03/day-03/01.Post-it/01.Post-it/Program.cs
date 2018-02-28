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

            public Posts (Color _BackGroundColor, string _notes, Color _TextColor)
            {
                BackGroundColor = _BackGroundColor;
                notes = _notes;
                Textcolor = _TextColor;

            }
        }
  
        static void Main(string[] args)
        {
            Posts post01 = new Posts();
            post01.BackGroundColor = Color.Orange;
            post01.notes = "Idea 1"; 
            post01.Textcolor = Color.Blue;

            Posts post02 = new Posts(Color.Pink, "Awesome!", Color.Black);

            //Posts post02 = new Posts();
            //post02.BackGroundColor = Color.Pink;
            //post02.notes = "Awesome!";
            //post02.Textcolor = Color.Black;

            Posts post03 = new Posts();
            post03.BackGroundColor = Color.Yellow;
            post03.notes = "Superb";
            post03.Textcolor = Color.Green;

            Console.WriteLine($"This is a note on {post01.BackGroundColor} paper, with {post01.Textcolor} letters, and says: {post01.notes}");
            Console.WriteLine($"This is a note on {post02.BackGroundColor} paper, with {post02.Textcolor} letters, and says: {post02.notes}");
            Console.ReadLine();
        }
    }
}
