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
            if (Values[0] != other.Values[0])
            {
                return Values[0].CompareTo(other.Values[0]);
            }
            else
            {
                return Values[1].CompareTo(other.Values[1]);
            }
        }

        public int[] GetValues() 
        {
            return Values;
        }

      

    }
}