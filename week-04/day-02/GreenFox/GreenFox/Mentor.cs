using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class Mentor : Person
    {
        public string level;

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }

        public Mentor()
        {
            this.level = "intermediate";
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} years old {2}, {3} level mentor.", name, age, gender, level);
        }
    }
}
