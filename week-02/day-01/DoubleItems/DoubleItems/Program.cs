using System;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `ag`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array

            int[] ag = new int[] { 3, 4, 5, 6, 7 };
            for (int i = 0; i < ag.Length; i++)
            {
                ag[i] *= 2;
            }
            foreach (var item in ag)
            {
                Console.WriteLine(item);
            }   
            Console.ReadLine();
        }
    }
}
