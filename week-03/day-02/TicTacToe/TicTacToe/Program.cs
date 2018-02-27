using System;
using System.Collections.Generic;
using System.IO;


namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // open and read it. The file data represents a tic-tac-toe
            // game result. Return 'X'/'O'/'draw' based on which player
            // has winning situation.

            Console.WriteLine(TicTacResult("win-o.txt"));
            // should print O

            Console.WriteLine(TicTacResult("win-x.txt"));
            // should print X

            Console.WriteLine(TicTacResult("draw.txt"));
            // should print draw
            Console.ReadLine();
        }

        static string TicTacResult(string path)
        {
            string[] moves = File.ReadAllLines(path);
            List<char> gamePlay = new List<char>();
            string result = "";

            for (int i = 0; i < moves.Length; i++)
            {
                foreach (var ch in moves[i])
                {
                    gamePlay.Add(ch);
                }
            }

            if (gamePlay[0] == gamePlay[1] && gamePlay[1] == gamePlay[2])
            {
                result = gamePlay[0].ToString() + " won";
            }
            else if (gamePlay[3] == gamePlay[4] && gamePlay[4] == gamePlay[5])
            {
                result = gamePlay[3].ToString() + " won";
            }
            else if (gamePlay[6] == gamePlay[7] && gamePlay[7] == gamePlay[8])
            {
                result = gamePlay[6].ToString() + " won";
            }
            else if (gamePlay[0] == gamePlay[3] && gamePlay[3] == gamePlay[6])
            {
                result = gamePlay[0].ToString() + " won";
            }
            else if (gamePlay[1] == gamePlay[4] && gamePlay[4] == gamePlay[7])
            {
                result = gamePlay[1].ToString() + " won";
            }
            else if (gamePlay[2] == gamePlay[5] && gamePlay[5] == gamePlay[8])
            {
                result = gamePlay[2].ToString() + " won";
            }
            else if (gamePlay[0] == gamePlay[4] && gamePlay[4] == gamePlay[8])
            {
                result = gamePlay[0].ToString() + " won";
            }
            else if (gamePlay[2] == gamePlay[4] && gamePlay[4] == gamePlay[6])
            {
                result = gamePlay[2].ToString() + " won";
            }
            else
            {
                result = "Draw";
            }


            
            
              



            return result;
            
            
        }
    }
}
