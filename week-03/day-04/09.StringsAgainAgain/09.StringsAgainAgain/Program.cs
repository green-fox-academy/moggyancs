using System;

namespace _07.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the
            // adjacent chars are now separated by a "*".

            string myString = "super";
            Console.WriteLine(XtoY(myString));
            Console.ReadLine();

        }

        static string XtoY(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }
            else if (s.Substring(0, 1) == "*")
            {
                return s.Substring(0, 1) + XtoY(s.Substring(1));
            }
            else
            {
                return s.Substring(0, 1) + "*" + XtoY(s.Substring(1));
            }

        }
    }
}
