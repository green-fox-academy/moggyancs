using System;

namespace Domino
{
    public class Domino
    {
        private readonly int[] Values; // Values is an int type array

        public Domino(int valueA, int valueB) // this is a constructor
        {
            this.Values = new int[] { valueA, valueB }; // creates the array of the array of numberpairs
        }

        public int[] GetValues() // allows to access the value pairs
        {
            return Values;
        }
    }
}