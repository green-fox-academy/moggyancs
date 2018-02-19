using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `nimals`
            //   with the following content: `["kuty", "macsk", "cic"]`
            // - Add all elements an `"a"` at the end

            string[] nimals = new string[] { "kuty", "macsk", "cic" };
            foreach (var item in nimals)
            {
                Console.WriteLine(item + "a");
            }
            Console.ReadLine();
        }
    }
}
