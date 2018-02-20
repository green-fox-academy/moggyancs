using System;
using System.Collections.Generic;

namespace _05_IsInList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };
            
            // Check if list contains all of the following elements: 4,8,12,16
            // Create a method that accepts list as an input
            // it should return "true" if it contains all, otherwise "false"
            Console.WriteLine(CheckNums(list));
            Console.ReadLine();
        }

        static Boolean CheckNums (List<int> numbers)
        {
            Boolean valid;
            if (numbers.Contains(4) && numbers.Contains(8) && numbers.Contains(12) && numbers.Contains(16))
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            return valid;

        }
    }
}
