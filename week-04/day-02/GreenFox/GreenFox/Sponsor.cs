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
    }

}
