using NUnit.Framework;
using Testing.Models;

namespace TestingUnitTests
{
    [TestFixture]
    public class AppleTest
    {
        [TestCase]
        public void GetAnApple_ShouldReturn_applestring()
        {
            var apple = new Apple();

            var result = apple.GetAnApple();
            Assert.AreEqual("apple", result);
        }
    }
}
