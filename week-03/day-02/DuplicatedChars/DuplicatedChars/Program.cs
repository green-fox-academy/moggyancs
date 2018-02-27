using System;
using System.IO;
using System.Collections.Generic;

namespace DuplicatedChars
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a method that decrypts the duplicated-chars.txt 

            string source = "poem.txt";
            RemoveDuplicate(source);
        }

        static void RemoveDuplicate(string path)
        {
            string[] poemLines = File.ReadAllLines(path);
            List<char> uniqueChars = new List<char>();

            foreach (var line in poemLines)
            {
                 for (int i = 0; i < line.Length; i++)
                {
                    if ( i % 2 != 0 || line[i] == '\n')
                    {
                        uniqueChars.Add(line[i]);
                        if (i == line.Length - 1)
                        {
                            uniqueChars.Add('\n');
                        }
                    }
                }   
                
                
            }
            File.WriteAllText("poemsorted.txt", string.Join("", uniqueChars));

        }
    }
}
