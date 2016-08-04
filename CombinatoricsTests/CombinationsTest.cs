using System.Linq;
using Facet.Combinatorics;
using NUnit.Framework;
using TestHelper.Helpers;

namespace CombinatoricsTests
{
    [TestFixture]
    public class CombinationsTest
    {
        [Test]
        public void TestCombinationsWithThreeCharactersFromThreeCharacterSetWithoutRepetition()
        {
            char[] inputSet = { 'a', 'b', 'c' };
            var expectedResult = CombinationHelper.GetCombinationsOfThreeCharsFromThreeCharacterSetWithoutRepetition();

            var actualResult = new Combinations<char>(inputSet, 3, GenerateOption.WithoutRepetition).AsEnumerable();

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void TestCombinationsWithThreeCharactersFromThreeCharacterSetWithRepetition()
        {
            char[] inputSet = { 'a', 'b', 'c' };
            var expectedResult = CombinationHelper.GetCombinationsOfThreeCharsFromThreeCharacterSetWithRepetition();

            var actualResult = new Combinations<char>(inputSet, 3, GenerateOption.WithRepetition).AsEnumerable();

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void TestCombinationsWithThreeCharactersFromFourCharacterSetWithRepetition()
        {
            char[] inputSet = { 'a', 'b', 'c', 'd' };
            var expectedResult = CombinationHelper.GetCombinationsOfFourCharsWithRepetition();

            var actualResult = new Combinations<char>(inputSet, 3, GenerateOption.WithRepetition).AsEnumerable();

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void TestCombinationsWithThreeCharactersFromFourCharacterSetWithoutRepetition()
        {
            char[] inputSet = { 'a', 'b', 'c', 'd' };
            var expectedResult = CombinationHelper.GetCombinationsOfFourCharsWithoutRepetition();

            var actualResult = new Combinations<char>(inputSet, 3, GenerateOption.WithoutRepetition).AsEnumerable();

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
    }
}
