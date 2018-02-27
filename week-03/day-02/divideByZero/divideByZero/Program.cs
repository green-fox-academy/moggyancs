using System;

namespace divideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number");
            int ten = 10;
            int number = int.Parse(Console.ReadLine());
            try
            {
                double result = ten / number;
                Console.WriteLine(result);
            }
            catch (Exception)
            {

                Console.WriteLine("You cannod divide by zero, silly");
            }
            finally
            {
                Console.ReadLine();
            }

        


        }
    }
}
