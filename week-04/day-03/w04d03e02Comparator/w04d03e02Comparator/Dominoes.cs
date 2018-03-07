using System;
using System.Collections.Generic;

namespace w04d03e02Comparator
{
    public class Domino : IComparable<Domino>
    {
        private readonly int[] Values; 

        public Domino(int valueA, int valueB) 
        {
            this.Values = new int[] { valueA, valueB }; 
        }

        public int CompareTo(Domino other)
        {
            throw new NotImplementedException();
        }

        public int[] GetValues() 
        {
            return Values;
        }
    }
}