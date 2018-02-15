using System;

namespace _10.DefineBasicInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define several things as a variable then print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Whether you are married or not as a boolean

            string name = "Gerda";
            int age = 32;
            double heightInM = 1.72;
            bool isMarried = true;

            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am {0} years old", age);
            Console.WriteLine("I am {0} meters tall.", heightInM);
            Console.WriteLine("It is {0} that I am married.", isMarried);

            Console.ReadLine();

        }
    }
}
