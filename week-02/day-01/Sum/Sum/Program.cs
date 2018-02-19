using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter and returns with an integer

            Console.WriteLine("How many numbers shall I add together?");
            int many = int.Parse(Console.ReadLine());    
            
            Console.WriteLine(Sum(many));
            Console.ReadLine();
        }
        static int Sum(int number)
        {
            int summa = 0;
            for (int i = 0; i <= number; i++)
            {
                summa = summa + i;
            }
            return summa;
        }
      
    }
}

