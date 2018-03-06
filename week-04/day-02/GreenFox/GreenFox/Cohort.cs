using System;
using System.Collections.Generic;

namespace GreenFox
{
    internal class Cohort
    {
        string name;
        List<Student> students = new List<Student>();
        List<Mentor> mentors = new List<Mentor>();

        public Cohort(string name)
        {
            this.name = name;
        }

        public void Info()
        {
            System.Console.WriteLine($"The {name} cohort has {students.Count} students and {mentors.Count} mentors.");
        }

        internal void AddStudent(Student student)
        {
            students.Add(student);
        }

        internal void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }
    }
}