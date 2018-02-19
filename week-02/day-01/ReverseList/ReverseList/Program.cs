using System;

namespace ReverseList
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`
            int[] aj = new int[] { 3, 4, 5, 6, 7 };
            Array.Reverse(aj);
            foreach (var item in aj)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
