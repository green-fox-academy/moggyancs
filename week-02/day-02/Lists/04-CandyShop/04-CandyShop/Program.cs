using System;
using System.Collections.Generic;

namespace _04_CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.

            Console.WriteLine(Sweets(list));
            Console.ReadLine();
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"
        }

        public static string Sweets(List<object> yumms)
        {
            yumms[1] = "Croissant";
            yumms[3] = "Ice Cream";

            string cakes = "";
            for (int i = 0; i < yumms.Count; i++)
            {
                cakes += "\"" + yumms[i] + "\", ";
            }
            return cakes;
        }
    }
}
