using NUnit.Framework;
using TestNinja.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTest
{
    [TestFixture]
    class MathTest
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            this._math = new Math();
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbers()
        {
            var result = _math.GetOddNumbers(5);
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
        }

        [Test]
        public void GetOddNumbers_LimitIsZero_ReturnEmptyArray()
        {
            var result = _math.GetOddNumbers(0);
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetOddNumbers_LimitIsNegative_ReturnEmptyArray()
        {
            var result = _math.GetOddNumbers(-5);
            Assert.That(result, Is.Empty);
        }


    }
}
