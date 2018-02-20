using System;
using System.Collections.Generic;


namespace _03_AppendLetter
{
    class Program
    {
        private static object toArray;

        static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            Console.WriteLine(AppendA(far));
            Console.ReadLine();
            // Expected output: "kutya", "macska", "kacsa", "róka", "halacska"
        }

        static string AppendA(List<string> nimals)
        {
            string appended = "";
            for (int i = 0; i < nimals.Count; i++)
            {
                appended += nimals[i] + "a, " ;
            }
            return appended;
        }
    }
}
