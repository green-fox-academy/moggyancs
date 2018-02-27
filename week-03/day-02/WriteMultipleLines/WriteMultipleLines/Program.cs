using System;
using System.Collections.Generic;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes 3 parameters: a path, a word and a number,
            // than it should write to a file.
            // The path parameter should be a string, that describes the location of the file.
            // The word parameter should be a string, that will be written to the file as lines
            // The number paramter should describe how many lines the file should have.
            // So if the word is "apple" and the number is 5, than it should write 5 lines
            // to the file and each line should be "apple"
            // The function should not raise any error if it could not write the file.

            //delete the path file before running the code. Run with any number of lines, any input string.

            string path = "my-file.txt";
            string word = "word!";
            int lines = 4;

            FillTheFile(path, word, lines);

        }

        static void FillTheFile (string path, string word, int lines)
        {
            List<string> linesList = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                linesList.Add(word);
            }
            string[] myLines = linesList.ToArray();

            File.WriteAllLines(path, myLines);







        }
    }
}
