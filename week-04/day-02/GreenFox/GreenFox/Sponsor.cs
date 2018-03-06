using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class Sponsor : Person
    {
        public string company;
        public int hiredStudents;

        public Sponsor(string name, int age, string gender, string company) : base (name, age, gender)
        {
            this.company = company;
            hiredStudents = 0;
        }

        public Sponsor()
        {
            this.company = "Google";
        }

        public void Hire()
        {
            hiredStudents++;
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} years old {2} who represents {3} and  hired {4} students so far.", name, age, gender, company, hiredStudents);
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Hire brilliant junior software developers.");
        }
    }

}
