using System;
using System.IO;

namespace CountTheLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            string filename = "myfile.txt"; //myfile.txt does not exist, my-file.txt does.
            CountTheLines(filename);
            //CountTheLinesB(filename); - var lineCount = File.ReadLines(@"C:\file.txt").Count();
        }

        public static void CountTheLines(string path)
        {

            try
            {
                string[] readText = File.ReadAllLines(path);
                Console.WriteLine(readText.Length);
            }
            catch (Exception)
            {

                Console.WriteLine(0);
            }
            finally
            {
                Console.ReadLine();
            }
            

        }
    }
}
