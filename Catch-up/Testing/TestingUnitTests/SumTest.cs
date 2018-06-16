using NUnit.Framework;
using System.Collections.Generic;
using Testing.Models;

namespace TestingUnitTests
{
    [TestFixture]
    public class SumTest
    {
        static IEnumerable<object[]> SourceMethod()
        {

            List<object[]> sourcelist = new List<object[]>
            {
                new object[]
                {
                    new Dictionary<int, List<int>>()
                    {
                        { 0, new List<int>() { }
                        }
                    }
                },
                new object[] {new Dictionary<int, List<int>>() { { 1, new List<int>() { 1 } } } },
                new object[] {new Dictionary<int, List<int>>() { { 3, new List<int>() { 1, 1, 1 } } } }
            };

            return sourcelist;

        }

        [TestCaseSource(nameof(SourceMethod))]
        public void AddListedNumbers_withNotNullLists(Dictionary<int, List<int>> input)
        {
            var myMath = new Sum();
            int result = 0;
            foreach (var value in input.Values)
            {
                result = myMath.AddListedNumbers(value);
                foreach (var key in input.Keys)
                {
                    Assert.AreEqual(key, result);
                }
            }
        }

        [TestCase(1, 2, 3, 6)]
        [TestCase(4, 5, 0, 9)]
        [TestCase(11, 22, 33, 66)]
        public void AddThreeNumbersShouldAddUp(int first, int second, int third, int result)
        {
            var myMath = new Sum();
            var sumOfNumbers = myMath.AddThreeNumbers(first, second, third);

            Assert.AreEqual(result, sumOfNumbers);
        }


        //[TestCase]
        //public void AddListedNumbers_WithNullList_TrhowsException()
        //{
        //    List<int> nullList = null;
        //    var myMath = new Sum();
        //    var result = myMath.AddListedNumbers(nullList);

        //    Assert.Throws(typeof();
        //}

    }
}