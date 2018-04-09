using System.Collections.Generic;

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
