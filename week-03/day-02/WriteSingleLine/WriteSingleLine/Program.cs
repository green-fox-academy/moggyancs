using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"

            string path = "myfile.txt"; //my-file.txt exists, can be edited, myfile.txt does not.
            string[] myName = { "Gerda", "Zsuzsanna", "Csuzdi" };


            if (File.Exists(path))
            {
                File.WriteAllLines(path, myName);
            }

            try
            {
                string[] readText = File.ReadAllLines(path);
                foreach (string s in readText)
                {
                    Console.Write(s + " ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: " + path);
            }
            Console.ReadLine();
        }
    }
}
