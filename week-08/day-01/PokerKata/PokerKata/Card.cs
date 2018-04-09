using System;

namespace PokerKata
{
    public class Card
    {
        char color;
        int value;

        public Card(string valueColor)
        {
            char[] ca = valueColor.ToCharArray();
            this.color = ca[ca.Length-1];
            
            this.value = Convert.ToInt32(valueColor.Substring(0, ca.Length - 1));
        }
                       
    }
}