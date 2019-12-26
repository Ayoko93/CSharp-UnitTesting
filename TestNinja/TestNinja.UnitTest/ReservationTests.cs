using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            var reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsReservationCreator_ReturnsTrue()
        {
            var user = new User() { IsAdmin = false };
            var reservation = new Reservation() { MadeBy = user};

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsNotReservationCreator_ReturnsFalse()
        {
            var user = new User() { IsAdmin = false };
            var anotherUser = new User() { IsAdmin = false };
            var reservation = new Reservation() { MadeBy = user };

            var result = reservation.CanBeCancelledBy(anotherUser);

            Assert.IsFalse(result);
        }
        /*
        [TestMethod]
        public void CanBeCancelledBy_UserIsNull_ReturnsFalse()
        {
            var reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(null);

            Assert.IsTrue(result);
        }
        */
    }
}
