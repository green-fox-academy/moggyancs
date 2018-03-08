using NUnit.Framework;

namespace w04d04e01Apple
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void Apple()
        {
            //Arrange
            Fruit apple = new Fruit("apple");

            //Act + Assert
            Assert.AreEqual("This is an apple", apple.GetFruit());
        }
    }
}
