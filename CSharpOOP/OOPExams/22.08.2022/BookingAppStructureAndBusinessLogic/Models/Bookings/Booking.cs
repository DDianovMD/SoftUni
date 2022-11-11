using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Utilities.Messages;
using System;
using System.Text;

namespace BookingApp.Models.Bookings
{
    public class Booking : IBooking
    {
        private int residenceDuration;
        private int adultsCount;
        private int childrenCount;
        private int bookingNumber;

        public Booking(IRoom room, int residenceDuration, int adultsCount, int childrensCount, int bookingNumber)
        {
            this.Room = room;
            this.ResidenceDuration = residenceDuration;
            this.AdultsCount = adultsCount;
            this.ChildrenCount = childrensCount;
            this.bookingNumber = bookingNumber;
        }

        public IRoom Room { get; private set; }

        public int ResidenceDuration
        {
            get
            {
                return this.residenceDuration;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.DurationZeroOrLess);
                }

                residenceDuration = value;
            }
        }

        public int AdultsCount
        {
            get
            {
                return adultsCount;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException(ExceptionMessages.AdultsZeroOrLess);
                }

                adultsCount = value;
            }
        }

        public int ChildrenCount
        {
            get
            {
                return childrenCount;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.ChildrenNegative);
                }

                childrenCount = value;
            }
        }

        public int BookingNumber { get => this.bookingNumber; }

        public double TotalPaid()
        {
            return Math.Round(ResidenceDuration * this.Room.PricePerNight, 2);
        }
        public string BookingSummary()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Booking number: {BookingNumber}");
            result.AppendLine($"Room type: {Room.GetType().Name}");
            result.AppendLine($"Adults: {AdultsCount} Children: {ChildrenCount}");
            result.AppendLine($"Total amount paid: {TotalPaid():F2} $");

            return result.ToString().Trim();
        }
    }
}
