using System;
using System.Collections.Generic;

namespace Testing.Models
{
    public static class Anagram
    {
        public static bool IsAnagram(string first, string second)
        {
            try
            {
                Dictionary<char, int> pool = new Dictionary<char, int>();
                if (first.Length != second.Length)
                    return false;

                else if (first == second)
                    return true;
                else
                    foreach (char amount in first.ToCharArray())
                    {
                        if (pool.ContainsKey(amount))
                            pool[amount]++;
                        else
                            pool.Add(amount, 1);
                    }
                foreach (char amount in second.ToCharArray())
                {
                    if (!pool.ContainsKey(amount))
                        return false;
                    if (--pool[amount] == 0)
                        pool.Remove(amount);
                }
                return pool.Count == 0;
            }
            catch (ArgumentNullException)
            {

                throw new ArgumentNullException("no words added");
            }
        }
    }
}
