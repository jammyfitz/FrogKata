using FrogKata.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogKataTests.Services
{
    [TestFixture]
    public class FrogServiceShould
    {
        [Test]
        public void NumberOfWaysShouldReturnOneGivenOne()
        {
            const int numberOfSteps = 1;
            const int expectedOutcome = 1;
            var frogService = new FrogService();

            var actualOutcome = frogService.NumberOfWays(numberOfSteps);

            Assert.That(actualOutcome, Is.EqualTo(expectedOutcome));
        }

        [Test]
        public void NumberOfWaysShouldReturnTwoGivenTwo()
        {
            const int numberOfSteps = 2;
            const int expectedOutcome = 2;
            var frogService = new FrogService();

            var actualOutcome = frogService.NumberOfWays(numberOfSteps);

            Assert.That(actualOutcome, Is.EqualTo(expectedOutcome));
        }

        [Test]
        public void NumberOfWaysShouldReturnThreeGivenThree()
        {
            const int numberOfSteps = 3;
            const int expectedOutcome = 3;
            var frogService = new FrogService();

            var actualOutcome = frogService.NumberOfWays(numberOfSteps);

            Assert.That(actualOutcome, Is.EqualTo(expectedOutcome));
        }

        [Test]
        public void NumberOfWaysShouldReturnFiveGivenFour()
        {
            const int numberOfSteps = 4;
            const int expectedOutcome = 5;
            var frogService = new FrogService();

            var actualOutcome = frogService.NumberOfWays(numberOfSteps);

            Assert.That(actualOutcome, Is.EqualTo(expectedOutcome));
        }
    }
}
