﻿using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        {
            var reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation() { MadeBy = user};

            var result = reservation.CanBeCancelledBy(user);

            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_DifferentUserCancellingTheReservation_ReturnFalse()
        {
            var reservation = new Reservation() { MadeBy = new User()};

            var result = reservation.CanBeCancelledBy(new User());

            Assert.That(result, Is.False);
        }
    }
}
