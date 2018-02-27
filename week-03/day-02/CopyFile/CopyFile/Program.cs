using System;
using System.IO;
using System.Collections.Generic;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            string fileFrom = "my-file.txt";
            string fileTo = "my-file2.txt";
            bool result = CopyMyFile(fileFrom, fileTo);

            Console.ReadLine();
        }

        static bool CopyMyFile(string fileFrom, string fileTo)
        {
                if (!File.Exists(fileTo))
                {
                    string[] original = File.ReadAllLines(fileFrom);
                    File.WriteAllLines(fileTo, original);
                    Console.WriteLine("Copy was successful");
                    return true;
                }
                else
                {
                    Console.WriteLine("the file had been copied before");
                    return false;
                }

            
        }
           

    }
}
