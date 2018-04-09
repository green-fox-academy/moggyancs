using NUnit.Framework;
using PokerKata;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void CardExists()
        {
            //AAA 
            //var pokerKata = new PokerKataClass();
            //var result = pokerKata.AddNums(1, 1);
            //Assert.AreEqual(2, result);

            var card = new Card("10H");
            Assert.AreNotEqual(card, null);
        }
        [Test]
        public void CardWithFigure()
        {
            var card = new Card("KH");
            Assert.AreNotEqual(card, null);
        }
    }
}
