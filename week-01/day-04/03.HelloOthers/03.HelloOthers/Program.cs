using System;

namespace _03.HelloOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of the person on your right? ");
            string nameOne = Console.ReadLine();
                

            Console.WriteLine("What is the name of the person on your left? ");
            string nameTwo = Console.ReadLine();

            Console.WriteLine("What is the name of the person sitting in front of you? ");
            string nameThree = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", nameOne);
            Console.WriteLine("Hello, {0}!", nameTwo);
            Console.WriteLine("Hello, {0}!", nameThree);

            Console.ReadLine();
       

            // Greet 3 of your classmates with this program, in three separate lines
            // like:
            //
            // Hello, Esther!
            // Hello, Mary!
            // Hello, Joe!


        }
    }
}
