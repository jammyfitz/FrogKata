using System.Linq;
using Facet.Combinatorics;
using NUnit.Framework;
using TestHelper.Helpers;

namespace CombinatoricsTests
{
    [TestFixture]
    public class PermutationsTest
    {
        [Test]
        public void TestPermutationsWithThreeDistinctCharactersWithoutRepetition()
        {
            char[] inputSet = { 'a', 'b', 'c' };
            var expectedResult = PermutatorHelper.GetPermutationsOfThreeChars();

            var actualResult = new Permutations<char>(inputSet, GenerateOption.WithoutRepetition).AsEnumerable();

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void TestPermutationsWithThreeDistinctCharactersWithRepetition()
        {
            char[] inputSet = { 'a', 'b', 'c' };
            var expectedResult = PermutatorHelper.GetPermutationsOfThreeChars();

            var actualResult = new Permutations<char>(inputSet, GenerateOption.WithRepetition).AsEnumerable();

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void TestPermutationsWithoutRepetition()
        {
            char[] inputSet = { 'a', 'a', 'c' };
            var expectedResult = PermutatorHelper.GetPermutationsWithoutRepetition();

            var actualResult = new Permutations<char>(inputSet).AsEnumerable();

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void TestPermutationsWithRepetition()
        {
            char[] inputSet = { 'a', 'a', 'c' };
            var expectedResult = PermutatorHelper.GetPermutationsWithRepetition();

            var actualResult = new Permutations<char>(inputSet, GenerateOption.WithRepetition).AsEnumerable();

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
    }
}
