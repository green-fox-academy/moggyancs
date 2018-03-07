using System;
using System.Collections.Generic;

namespace w04d03e02Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Domino> dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 7));
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));

            foreach (var domino in dominoes)
            {
                Console.Write("[" + string.Join(",", domino.GetValues()) + "]");
            }
            dominoes.Sort();

            Console.WriteLine();

            foreach (var domino in dominoes)
            {
            Console.Write("[" + string.Join(",", domino.GetValues()) + "]");
            }

            Console.ReadLine();
        }
    }
}
