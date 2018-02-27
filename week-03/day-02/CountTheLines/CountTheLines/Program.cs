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

            string filename = @"C:\Users\moggy\greenfox\moggyancs\week-03\day-02\CountTheLines\CountTheLines\my-file.txt"; //myfile.txt does not exist, my-file.txt does.
            CountTheLines(filename);
            CountTheLinesB(filename); 
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
        public static void CountTheLinesB(string path)
        {
            try
            {
                var lineCount = File.ReadAllLines(path).Length;
                Console.WriteLine(lineCount);
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
