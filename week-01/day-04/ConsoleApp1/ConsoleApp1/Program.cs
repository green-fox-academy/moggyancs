using System;

namespace Material
{
    class Program
    {
        static void Main(string[] args)
        {
            byte weight;
            weight = 75;
            int birthYear = 1985;
            float pi = 3.14f;
            double priceOfACar = 599.999;
            bool isMarried = true;
            char firstLetterFirstName = 'G';
            string name = "moira85";

           // console write options
            Console.Write("Hello\t");
            Console.WriteLine("Pebbles!");
            Console.WriteLine("My emailaddress is " + name + "@gmail.com, but my name starts with " + firstLetterFirstName);
            Console.WriteLine("The price of the car is ${0}, and pi is {1}.", priceOfACar, pi);

            // if - else
            int randomNumber = 5465872;
            if (randomNumber % 2 == 0)
            {
                Console.WriteLine("{0} is an even number", randomNumber);
            }            
            else
            {
                Console.WriteLine("{0} is an odd number", randomNumber);
            }          
            //while - 2 cases
            int randomity = 0;
            while (randomity < 100)
            {
                randomity += 10;
                Console.Write(randomity + "\t");
            }
            Console.WriteLine();

            int randomOther = 100;
            while (randomOther > 0)
            {
                Console.Write(randomOther + "\t");
                randomOther -= 10;
                
            }
            Console.WriteLine();

            //switch
            Console.WriteLine("Give me a number: ");
            int userNumber = int.Parse(Console.ReadLine());
            switch (userNumber % 3)
            {
                case 1:
                    Console.WriteLine(userNumber + " gives the remainder of 1, when divided by 3");
                    break;
                case 2:
                    Console.WriteLine(userNumber + " gives the remainder of 2, when divided by 3");
                    break;
                default:
                Console.WriteLine(userNumber + " is the multiplex of 3");
                    break;
            }


                Console.ReadLine();          
        }
    }
}
