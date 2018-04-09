using System;
using System.Collections.Generic;

namespace PokerKata
{
    public class Card
    {
        public char Color { get; set; }
        public int Value { get; set; }
        public List<Char> CardColors = new List<char>(){ 'H', 'S', 'D', 'C' };

        public Card(string valueColor)
        {
            char[] ca = valueColor.ToCharArray();

            try
            {
                Value = Convert.ToInt32(valueColor.Substring(0, ca.Length - 1));
            }
            catch (Exception)
            {
                if (ca[0] == 'J')
                {
                    Value = 11;
                }
                else if (ca[0] == 'K')
                {
                    Value = 12;
                }
                else if (ca[0] == 'Q')
                {
                    Value = 13;
                }
                else if (ca[0] == 'A')
                {
                    Value = 14;
                }
                else
                {
                    //throw new Exception("Not a valid value");
                }
            }
        }
    }
}