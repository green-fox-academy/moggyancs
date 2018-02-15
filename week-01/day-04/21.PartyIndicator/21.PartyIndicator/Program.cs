using System;

namespace _21.PartyIndicator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people


            Console.WriteLine("How many girls were there last night? ");
            int girls = int.Parse(Console.ReadLine());
            Console.WriteLine("And how many boys? ");
            int boys = int.Parse(Console.ReadLine());

            if (girls == 0)
            {
                Console.WriteLine("HAHAHA so you went to a SAUSAGE party!!");
            }

            else if (girls == boys && girls + boys > 20)
            {
                Console.WriteLine("That must have been an excellent party!");
            }
            else if (girls != boys && girls + boys > 20)
            {
                Console.WriteLine("That was qute a cool party!");
            }
            else 
            {
                Console.WriteLine("That was just an average party.");
            }
            

            Console.ReadLine();
            
        }
    }
}
