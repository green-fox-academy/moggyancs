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

        [TestCase]
        public void EmptyList()
        {
            var program = new Program();

            List<int> EmptyList = new List<int>() { };

            Assert.AreEqual(0, program.Sum(EmptyList));
        }

        [TestCase]
        public void MultipleNumbers()
        {
            var program = new Program();

            List<int> ManyNumbers = new List<int>() {2, 4, 6, 8, 10 };

            Assert.AreEqual(30, program.Sum(ManyNumbers));
        }

        [TestCase]
        public void NullList()
        {
            var program = new Program();

            List<int> Null = null;

            Assert.AreEqual(0, program.Sum(Null));
        }
    }
}
