using BookingApp.Models.Rooms.Contracts;
using BookingApp.Utilities.Messages;
using System;

namespace BookingApp.Models.Rooms
{
    public abstract class Room : IRoom
    {
        private double pricePerNight = 0;

        public Room(int bedCapacity)
        {
            this.BedCapacity = bedCapacity;
        }

        public int BedCapacity { get; private set; }
        public double PricePerNight
        {
            get
            {
                return this.pricePerNight;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.PricePerNightNegative);
                }

                pricePerNight = value;
            }
        }

        public void SetPrice(double price)
        {
            this.PricePerNight = price;
        }
    }
}
