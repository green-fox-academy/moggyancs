using System;

namespace PokerKata
{
    public class Card
    {
        private char Color { get; set; }
        private int Value { get; set; }

        public Card(string valueColor)
        {
            char[] ca = valueColor.ToCharArray();
            Color = ca[ca.Length - 1];

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
                if (ca[0] == 'K')
                {
                    Value = 12;
                }
                if (ca[0] == 'Q')
                {
                    Value = 13;
                }
                if (ca[0] == 'A')
                {
                    Value = 14;
                }
            }
        }
    }
}