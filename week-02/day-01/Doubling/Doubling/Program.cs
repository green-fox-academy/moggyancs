using System;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an integer variable named `ak` and assign the value `123` to it
            // - Create a function called `doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `doubling(ak)`

            int ak = 123;
            int result = Doubling(ak);
            Console.WriteLine(result);

            Console.ReadLine();
        }
        static int Doubling(int number)
        {
            return 2 * number;
        }
    }
}
