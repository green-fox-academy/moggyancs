using System;

namespace _04.Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).

            int baseInt = 2;
            int expInt = 10;

            Console.WriteLine(Power(baseInt, expInt));
            Console.ReadLine();
        }

        static int Power (int baseInt, int expInt)
        {
            if (expInt == 0)
            {
                return 1;
            }
            else
            {
                return baseInt * Power(baseInt, expInt - 1);
            }
        }
    }
}
