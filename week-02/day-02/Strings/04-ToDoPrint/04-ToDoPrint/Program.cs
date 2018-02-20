using System;
using System.Text;

namespace _04_ToDoPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indention

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            StringBuilder toDo = new StringBuilder();
            toDo.Append(todoText);
            toDo.Insert(0, "My todo:\n");
            toDo.Append(" - Download games\n");
            toDo.Append("\t - Diablo");

            todoText = toDo.ToString();

            Console.WriteLine(todoText);
            Console.ReadLine();
        }
    }
}
