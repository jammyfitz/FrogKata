using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FrogKata.Services;
using FrogKataTests.Helpers;
using NUnit.Framework;

namespace FrogKataTests.Services
{
    [TestFixture]
    public class PermutatorServiceTest
    {
        [Test]
        public void PermutatorServiceShouldReturnPermutationsOfThreeIntsOfThreeLength()
        {
            var expectedResult = TestHelper.GetPermutationsOfThreeInts();
            var permutationalInput = Enumerable.Range(1, 3);

            IEnumerable <IEnumerable<int>> actualResult = PermutatorService.GetPermutations(permutationalInput, 3);

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void PermutatorServiceShouldReturnPermutationsOfThreeCharactersOfThreeLength()
        {
            var expectedResult = TestHelper.GetPermutationsOfThreeChars();
            var permutationalInput = new char[] {'a', 'b', 'c'};

            IEnumerable<IEnumerable<char>> actualResult = PermutatorService.GetPermutations(permutationalInput, 3);

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void PermutatorServiceShouldReturnPermutationsOfFourIntsOfFourLength()
        {
            var expectedResult = TestHelper.GetPermutationsOfFourIntsFromFourInts();
            var permutationalInput = Enumerable.Range(1, 4);

            IEnumerable<IEnumerable<int>> actualResult = PermutatorService.GetPermutations(permutationalInput, 4);

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void PermutatorServiceShouldReturnPermutationsOfFourIntsOfThreeLength()
        {
            var expectedResult = TestHelper.GetPermutationsOfFourIntsFromThreeInts();
            var permutationalInput = Enumerable.Range(1, 4);

            IEnumerable<IEnumerable<int>> actualResult = PermutatorService.GetPermutations(permutationalInput, 3);

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
    }
}
