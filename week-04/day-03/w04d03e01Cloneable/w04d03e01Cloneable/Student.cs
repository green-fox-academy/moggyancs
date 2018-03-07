using System;
using System.Collections.Generic;
using System.Text;

namespace w04d03e01Cloneable
{
    class Student : ICloneable
    {
        private string name;
        private int age;
        private string gender;
        private string previousOrganisation;
        private int skippedDays;

        public Student(string name, int age, string gender, string previousOrganisation)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.previousOrganisation = previousOrganisation;
            this.skippedDays = 0;
        }

        public Student()
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
            this.previousOrganisation = "The School of life";
            this.skippedDays = 0;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string PreviousOrganisation { get => previousOrganisation; set => previousOrganisation = value; }
        public int SkippedDays { get => skippedDays; set => skippedDays = value; }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer");
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} years old {2}, from {3}, who skipped {4} days from the course already", name, age, gender, previousOrganisation, skippedDays);
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }

        public object Clone()
        {
            return new Student(this.name, this.age, this.gender, this.previousOrganisation);
        }
    }
}
