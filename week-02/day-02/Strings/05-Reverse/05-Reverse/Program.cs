using System;

namespace _05_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Reverse(reversed);
            Console.WriteLine(Reverse2(reversed));
            Reverse2(reversed);
            Console.WriteLine(Reverse3(reversed));
            Console.ReadLine();
        }
        public static void Reverse(string stringToReverse)
        {
            var myArray = stringToReverse.ToCharArray();
            Array.Reverse(myArray);
            foreach (var item in myArray)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        public static string Reverse2(string stringToReverse)
        {
            string ordered = "";
            for (int i = stringToReverse.Length-1; i >= 0; i--)
            {
                ordered += stringToReverse[i];
            }
            return ordered;
        }

        public static string Reverse3(string stringToReverse)
        {
            string ordered = "";
            for (int i = stringToReverse.Length; i > 0; i--)
            {
                ordered += stringToReverse.Substring(i-1, 1);
            }
            return ordered;
        }
    }
}
