using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    class DemeritPointsCalculatorTests
    {

        DemeritPointsCalculator calculator;


        [SetUp]
        public void SetUp()
        {
            calculator = new DemeritPointsCalculator();
        }


        [Test]
        [TestCase(0, 0)]
        [TestCase(50, 0)]
        [TestCase(65, 0)]
        [TestCase(69, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expectedDemeritPoints)
        {
            int result = calculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(expectedDemeritPoints));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {

            Assert.That(() => calculator.CalculateDemeritPoints(speed),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

        }



    }
}
