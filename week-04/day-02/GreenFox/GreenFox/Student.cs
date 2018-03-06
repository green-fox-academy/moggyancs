using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class Student : Person
    {
        public string previousOrganisation;
        public int skippedDays;

        public Student (string name, int age, string gender, string prevOrg ) : base(name, age, gender)
        {
            skippedDays = 0;
            previousOrganisation = prevOrg;
        }

        public Student()
        {
            this.previousOrganisation = "The School of life";
        }


        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} years old {2}, from {3}, who skipped {4} days from the course already", name, age, gender, previousOrganisation, skippedDays);
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }
    }
}
