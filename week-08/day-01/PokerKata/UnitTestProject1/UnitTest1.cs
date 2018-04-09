using NUnit.Framework;
using PokerKata;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void CardInit()
        {
            var cardA = new Card("4D");
            var cardB = new Card("10H");
            Assert.AreNotEqual(cardA, null);
            Assert.AreNotEqual(cardB, null);
        }

        [Test]
        public void CardWithFigure()
        {
            var card = new Card("KH");
            Assert.AreNotEqual(card, null);
        }

        [Test]
        public void HandInit()
        {
            var hand = new Hand(new string[] { "2H", "3D", "5S", "9C", "KD" });
            Assert.AreNotEqual(hand, null);
        }

        [Test]
        public void InvalidCardColor()
        {
            var card = new Card("10L");

        }
    }
}
