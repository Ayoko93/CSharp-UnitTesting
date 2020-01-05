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
    class FizzBuzzTest
    {
        [Test]
        public void GetOutput_NumberIsDividableByThreeAndFive_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz").IgnoreCase);
        }
        
        [Test]
        public void GetOutput_NumberIsDividableByThree_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("Fizz").IgnoreCase);
        }
        
        [Test]
        public void GetOutput_NumberIsDividableByFive_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz").IgnoreCase);
        }
        [Test]
        public void GetOutput_NumberIsNotDividableByThreeOrFive_ReturnNumber()
        {
            var result = FizzBuzz.GetOutput(2);

            Assert.That(result, Is.EqualTo("2").IgnoreCase);
        }
    }
}
