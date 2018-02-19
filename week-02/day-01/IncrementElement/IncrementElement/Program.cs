using System;

namespace IncrementElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Create an array variable named `t`
            //  with the following content: `[1, 2, 3, 4, 5]`
            //- Increment the third element
            //- Print the third element
            int[] t = new int[] { 1, 2, 3, 4, 5 };
            t[2]++;
            Console.WriteLine(t[2]);
            Console.ReadLine();
        }
    }
}
