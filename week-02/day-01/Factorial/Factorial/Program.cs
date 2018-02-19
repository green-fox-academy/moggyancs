using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial
            Console.WriteLine("I can calculate factorial. Give me a number!");
            int myNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorio(myNumber));

            Console.ReadLine();
        }
        static int Factorio(int number)
        {
            int facto = 1;
            for (int i = number; i>=1; i--)
            {
                facto *= i;
            }
            return facto;
        }
            
		
    }
}
