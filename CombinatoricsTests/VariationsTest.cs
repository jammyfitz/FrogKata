﻿using System.Linq;
using Facet.Combinatorics;
using NUnit.Framework;
using TestHelper.Helpers;

namespace CombinatoricsTests
{
    public class VariationsTest
    {
        [Test]
        public void TestVariationsWithThreeCharactersFromThreeCharacterSetWithoutRepetition()
        {
            char[] inputSet = { 'a', 'b', 'c' };
            var expectedResult = VariatorHelper.GetVariationsOfThreeCharsFromThreeCharsWithoutRepetition();

            var actualResult = new Variations<char>(inputSet, 3, GenerateOption.WithoutRepetition).AsEnumerable();

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void TestVariationsWithThreeCharactersFromThreeCharacterSetWithRepetition()
        {
            char[] inputSet = { 'a', 'b', 'c' };
            var expectedResult = VariatorHelper.GetVariationsOfThreeCharsFromThreeCharsWithRepetition();

            var actualResult = new Variations<char>(inputSet, 3, GenerateOption.WithRepetition).AsEnumerable();

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void TestVariationsWithThreeCharactersFromFourCharacterSetWithoutRepetition()
        {
            char[] inputSet = { 'a', 'b', 'c', 'd' };
            var expectedResult = VariatorHelper.GetVariationsOfThreeCharsFromFourCharsWithoutRepetition();

            var actualResult = new Variations<char>(inputSet, 3, GenerateOption.WithoutRepetition).AsEnumerable();

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void TestVariationsWithThreeCharactersFromFourCharacterSetWithRepetition()
        {
            char[] inputSet = { 'a', 'b', 'c', 'd' };
            var expectedResult = VariatorHelper.GetVariationsOfThreeCharsFromFourCharsWithRepetition();

            var actualResult = new Variations<char>(inputSet, 3, GenerateOption.WithRepetition).AsEnumerable();

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void TestVariationsWithRepetitionForTwoNumbers()
        {
            var inputSet = new[] { 1, 2 };
            var expectedResult = VariatorHelper.GetVariationsWithRepetitionForTwoNumbers();

            var actualResult = new Variations<int>(inputSet, 2, GenerateOption.WithRepetition).AsEnumerable();

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void TestVariationsWithRepetitionForThreeNumbers()
        {
            var inputSet = new[] { 1, 2, 3};
            var expectedResult = VariatorHelper.GetVariationsWithRepetitionForThreeNumbers();

            var actualResult = new Variations<int>(inputSet, 3, GenerateOption.WithRepetition).AsEnumerable();

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
    }
}
