using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"

            try
            {
            StreamReader myReader = new StreamReader("myfile.txt");
            string line = "";
                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                        Console.WriteLine(line);
                }
                myReader.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, the file you are looking for does not exist");
                
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
