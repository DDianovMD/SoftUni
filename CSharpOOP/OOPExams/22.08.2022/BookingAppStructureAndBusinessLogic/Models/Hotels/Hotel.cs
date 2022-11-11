using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Hotels.Contacts;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Repositories.Contracts;
using BookingApp.Utilities.Messages;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using BookingApp.Models.Bookings;
using BookingApp.Repositories;
using BookingApp.Models.Rooms;

namespace BookingApp.Models.Hotels
{
    public class Hotel : IHotel
    {
        private string fullName;
        private int category;
        private IRepository<IBooking> bookingsRepository;
        private IRepository<IRoom> roomsRepository;

        public Hotel(string fullName, int category)
        {
            this.FullName = fullName;
            this.Category = category;
            bookingsRepository = new BookingRepository();
            roomsRepository = new RoomRepository();
        }
        public string FullName
        {
            get
            {
                return this.fullName;
            }

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.HotelNameNullOrEmpty);
                }

                this.fullName = value;
            }
        }
        public int Category
        {
            get
            {
                return this.category;
            }
            private set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCategory);
                }

                this.category = value;
            }
        }
        public double Turnover
        {
            get
            {
                return Math.Round(Bookings.All().Sum(x => x.ResidenceDuration * x.Room.PricePerNight), 2);
            }
        }

        public IRepository<IRoom> Rooms { get => this.roomsRepository; }

        public IRepository<IBooking> Bookings { get => this.bookingsRepository;}
    }
}
