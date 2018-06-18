using NUnit.Framework;
using System;
using Testing.Models;

namespace TestingUnitTests.BasicTests
{
    [TestFixture]
    public class AnagramTests
    {
        [TestCase("a", "a")]
        [TestCase("ab", "ba")]
        [TestCase("dog", "god")]
        [TestCase("abc123", "a1b2c3")]
        [TestCase("coins kept", "in pockets")]
        public void RealAnagramsReturnTrue(string first, string second)
        {
            Assert.IsTrue(Anagram.IsAnagram(first, second));
        }

        [TestCase]
        public void UnequalLengthWordsReturnFalse()
        {
            Assert.IsFalse(Anagram.IsAnagram("good", "god"));
        }

        [TestCase ("batman", null)]
        [TestCase(null, null)]
        [TestCase(null, "BATMAN")]
        public void MissingArgument_TrhowsException(string first, string second)
        {
            Assert.Throws<NullReferenceException>(() => Anagram.IsAnagram(first, second));
        }
    }
}
