using System;
using System.Collections.Generic;

namespace w04d03e01Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student("John", 20, "male", "BME");
            Student johnClone = (Student)john.Clone();

            john.Introduce();
            johnClone.Introduce();
            Console.WriteLine();

            johnClone.Age = 30;
            johnClone.Gender = "female";
            john.SkipDays(2);

            john.Introduce();
            johnClone.Introduce();

            Console.ReadLine();
        }
    }
}
