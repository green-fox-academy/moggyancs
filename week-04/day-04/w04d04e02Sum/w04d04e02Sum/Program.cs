using System;
using System.Collections.Generic;

namespace w04d04e02Sum
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public int Sum(List<int> numbers)
        {
            try
            {
                int value = 0;
                foreach (var number in numbers)
                {
                    value += number;
                }
                return value;
            }
            catch (NullReferenceException)
            {
                return 0;
            }
        }
    }
}
