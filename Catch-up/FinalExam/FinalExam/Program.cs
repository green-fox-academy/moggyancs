using System;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add a string to reverse!");

            string input = Console.ReadLine();
            string output = ReverseThis(input);

            Console.WriteLine("Read from the end: " + output);
            Console.ReadLine();
        }

        private static string ReverseThis(string toReverse)
        {
            string reversed = String.Empty;
            foreach (char ch in toReverse)
            {
                reversed = ch + reversed;
            }

            return reversed;
        }
    }
}
