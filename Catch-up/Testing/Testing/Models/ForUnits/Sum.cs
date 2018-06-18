using System;
using System.Collections.Generic;

namespace Testing.Models
{
    public class Sum
    {
        public int AddThreeNumbers(int first, int second, int third)
        {
            return first + second + third;
        }

        public int AddListedNumbers(List<int> numbers)
        {
            try
            {
                int result = 0;
                foreach (var number in numbers)
                {
                    result += number;
                }

                var dicti = new Dictionary<int, List<int>>() { { 3, new List<int>() { 1, 1, 1 } } };

                return result;
            }

            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("no list found");
            }

        }
    }
}