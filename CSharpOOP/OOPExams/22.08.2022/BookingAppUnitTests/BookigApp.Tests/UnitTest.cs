using FrontDeskApp;
using NUnit.Framework;
using System;
using System.Linq;

namespace BookigApp.Tests
{
    public class Tests
    {
        // Hotel tests
        [Test]
        public void HotelFullNameThrowsArgumentExceptionWhenAssignedToNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Hotel hotel = new Hotel(null, 1);
            });
        }

        [Test]
        public void HotelFullNameThrowsArgumentExceptionWhenAssignedToEmptyString()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Hotel hotel = new Hotel("", 1);
            });
        }

        [Test]
        public void HotelFullNameIsSetWithProperValue()
        {
            Hotel hotel = new Hotel("Test", 1);

            Assert.That(hotel.FullName, Is.EqualTo("Test"));
        }

        [Test]
        public void CategoryThrowsArgumentExceptionWhenValueIsZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Hotel hotel = new Hotel("Test", 0);
            });
        }

        [Test]
        public void CategoryThrowsArgumentExceptionWhenValueIsNegativeNumber()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Hotel hotel = new Hotel("Test", -1);
            });
        }

        [Test]
        public void CategoryThrowsArgumentExceptionWhenValueIsHigherThanFive()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Hotel hotel = new Hotel("Test", 6);
            });
        }

        [Test]
        public void HotelCategoryIsSetWithProperValue()
        {
            Hotel hotel = new Hotel("Test", 1);
            Assert.That(hotel.Category, Is.EqualTo(1));
        }

        [Test]
        public void TurnoverDefaultValueIsZero()
        {
            Hotel hotel = new Hotel("Test", 4);
            Assert.That(hotel.Turnover, Is.EqualTo(0));
        }

        [Test]
        public void TurnoverValueIsCalculatedProperly()
        {
            Hotel hotel = new Hotel("Test", 4);
            Room room = new Room(2, 2);
            hotel.AddRoom(room);
            hotel.BookRoom(1, 1, 1, 3);

            Assert.That(hotel.Turnover, Is.EqualTo(2));
        }

        [Test]
        public void RoomsAreInitializedInConstructor()
        {
            Hotel hotel = new Hotel("Test", 4);
            Assert.That(hotel.Rooms, Is.Not.Null);
        }

        [Test]
        public void BookingsAreInitializedInConstructor()
        {
            Hotel hotel = new Hotel("Test", 4);
            Assert.That(hotel.Bookings, Is.Not.Null);
        }

        [Test]
        public void AddRoomIsWorkingProperly()
        {
            Hotel hotel = new Hotel("Test", 4);
            Room room = new Room(2, 3);
            hotel.AddRoom(room);
            Assert.That(hotel.Rooms.Count, Is.EqualTo(1));
        }

        [Test]
        public void AddRoomIsThrowingExceptionWhenAddingNull()
        {
            Hotel hotel = new Hotel("Test", 4);
            hotel.AddRoom(null);

            Assert.That(hotel.Rooms.ElementAt(0), Is.EqualTo(null));
        }

        [Test]
        public void BookingWorksWithProperValues()
        {
            Hotel hotel = new Hotel("Test", 4);
            Room room = new Room(2, 2);
            hotel.AddRoom(room);
            hotel.BookRoom(1, 1, 1, 3);

            Assert.That(hotel.Bookings.Count, Is.EqualTo(1));
        }

        [Test]
        public void BookingIsNotAllowedWithZeroAdults()
        {
            Hotel hotel = new Hotel("Test", 4);
            Room room = new Room(2, 2);
            hotel.AddRoom(room);

            Assert.Throws<ArgumentException>(() =>
            {
                hotel.BookRoom(0, 1, 1, 3);
            });
        }

        [Test]
        public void BookingIsNotAllowedWithNegativeNumberOfAdults()
        {
            Hotel hotel = new Hotel("Test", 4);
            Room room = new Room(2, 2);
            hotel.AddRoom(room);

            Assert.Throws<ArgumentException>(() =>
            {
                hotel.BookRoom(-1, 1, 1, 3);
            });
        }

        [Test]
        public void BookingIsNotAllowedWithNegativeNumberOfChildren()
        {
            Hotel hotel = new Hotel("Test", 4);
            Room room = new Room(2, 2);
            hotel.AddRoom(room);

            Assert.Throws<ArgumentException>(() =>
            {
                hotel.BookRoom(1, -1, 1, 3);
            });
        }

        [Test]
        public void BookingIsNotAllowedWithDurationLessThanOneDay()
        {
            Hotel hotel = new Hotel("Test", 4);
            Room room = new Room(2, 2);
            hotel.AddRoom(room);

            Assert.Throws<ArgumentException>(() =>
            {
                hotel.BookRoom(1, 1, 0, 3);
            });
        }

        [Test]
        public void BedsNeededAreCalculatedProperly()
        {
            Hotel hotel = new Hotel("Test", 4);
            Room room = new Room(2, 2);
            hotel.AddRoom(room);
            hotel.BookRoom(1, 1, 1, 3);

            Assert.That(hotel.Bookings.ElementAt(0).Room.BedCapacity, Is.EqualTo(2));
        }

        [Test]
        public void BookingIsNotAllowedWithNegativeBudget()
        {
            Hotel hotel = new Hotel("Test", 4);
            Room room = new Room(2, 2);
            hotel.AddRoom(room);
            hotel.BookRoom(1, 1, 1, -1);

            Assert.That(hotel.Bookings.Count, Is.EqualTo(0));
        }

        // Room tests
        [Test]
        public void RoomPricePerNightCantBeZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Room room = new Room(1, 0);
            });
        }

        [Test]
        public void RoomPricePerNightIsSetProperly()
        {
            Room room = new Room(1, 1);
            Assert.That(room.PricePerNight, Is.EqualTo(1));
        }

        // Booking tests
        [Test]
        public void BookingResidenceDurationIsSetProperly()
        {
            Booking booking = new Booking(1, null, 2);

            Assert.That(booking.ResidenceDuration, Is.EqualTo(2));
        }

        [Test]
        public void BookingBookingNumberIsSetProperly()
        {
            Booking booking = new Booking(1, null, 2);

            Assert.That(booking.BookingNumber, Is.EqualTo(1));
        }
    }
}