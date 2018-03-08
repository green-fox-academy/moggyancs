using NUnit.Framework;
using System.Collections.Generic;
using w04d04e02Sum;

namespace SumTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void AddTwoNumbers ()
        {
            var program = new Program();

            List<int> TwoNumbers = new List<int>() { 2, 4 };

            Assert.AreEqual(6, program.Sum(TwoNumbers));
        }
    }
}
