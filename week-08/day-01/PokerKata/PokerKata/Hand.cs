using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerKata
{
    public class Hand
    {
        List<Card> hand = new List<Card>();

        public Hand(string[] cards)
        {
            foreach (var cardValue in cards)
            {
                hand.Add(new Card(cardValue));
            }
        }
    }
}
