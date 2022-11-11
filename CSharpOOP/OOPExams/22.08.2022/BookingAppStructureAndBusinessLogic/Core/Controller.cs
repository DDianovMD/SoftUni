using BookingApp.Core.Contracts;
using BookingApp.Models.Bookings;
using BookingApp.Models.Hotels;
using BookingApp.Models.Rooms;
using BookingApp.Repositories;
using BookingApp.Utilities.Messages;
using System;
using System.Linq;
using System.Text;

namespace BookingApp.Core
{
    public class Controller : IController
    {
        HotelRepository hotels = new HotelRepository();
        public string AddHotel(string hotelName, int category)
        {
            if (hotels.All().FirstOrDefault(x => x.FullName == hotelName) != null)
            {
                return String.Format(OutputMessages.HotelAlreadyRegistered, hotelName);
            }
            else
            {
                Hotel hotel = new Hotel(hotelName, category);
                hotels.AddNew(hotel);

                return String.Format(OutputMessages.HotelSuccessfullyRegistered, category, hotelName);
            }
        }

        public string BookAvailableRoom(int adults, int children, int duration, int category)
        {
            if (hotels.All().Where(x => x.Category == category).Count() == 0)
            {
                return String.Format(OutputMessages.CategoryInvalid, category);
            }
            else
            {
                var filteredHotels = hotels.All().Where(x => x.Category == category).OrderBy(x => x.FullName);

                for (int i = 0; i < filteredHotels.Count(); i++)
                {
                    var filteredAndOrderedRooms = filteredHotels.ElementAt(i).Rooms.All().Where(x => x.PricePerNight > 0).OrderBy(x => x.BedCapacity);

                    for (int j = 0; j < filteredAndOrderedRooms.Count(); j++)
                    {
                        if (filteredAndOrderedRooms.ElementAt(j).BedCapacity >= adults + children)
                        {
                            Booking booking = new Booking(filteredAndOrderedRooms.ElementAt(j), duration, adults, children, filteredHotels.ElementAt(i).Bookings.All().Count() + 1);

                            filteredHotels.ElementAt(i).Bookings.AddNew(booking);

                            return string.Format(OutputMessages.BookingSuccessful, filteredHotels.ElementAt(i).Bookings.All().Count(), filteredHotels.ElementAt(i).FullName);
                        }
                    }
                }

                return OutputMessages.RoomNotAppropriate;
            }

        }

        public string HotelReport(string hotelName)
        {
            Hotel hotel = hotels.All().FirstOrDefault(x => x.FullName == hotelName) as Hotel;

            if (hotel == null)
            {
                return $"Profile {hotelName} doesn’t exist!";
            }
            else
            {
                StringBuilder report = new StringBuilder();

                report.AppendLine($"Hotel name: {hotel.FullName}");
                report.AppendLine($"--{hotel.Category} star hotel");
                report.AppendLine($"--Turnover: {hotel.Turnover:F2} $");
                report.AppendLine($"--Bookings:");
                report.AppendLine();

                if (hotel.Bookings.All().Count == 0)
                {
                    report.AppendLine("none");
                }
                else
                {
                    foreach (var booking in hotel.Bookings.All())
                    {
                        report.AppendLine(booking.BookingSummary());
                        report.AppendLine();
                    }
                }

                return report.ToString().TrimEnd();
            }
        }

        public string SetRoomPrices(string hotelName, string roomTypeName, double price)
        {
            if (hotels.All().FirstOrDefault(x => x.FullName == hotelName) == null)
            {
                return $"Profile {hotelName} doesn’t exist!";
            }
            else
            {
                if (roomTypeName != "Apartment" && roomTypeName != "DoubleBed" && roomTypeName != "Studio")
                {
                    return $"Incorrect room type!";
                }

                var rooms = hotels.All().SelectMany(x => x.Rooms.All());

                if (rooms.Any(x => x.GetType().Name == roomTypeName) == false)
                {
                    return OutputMessages.RoomTypeNotCreated;
                }

                var currentRoom = rooms.Where(x => x.GetType().Name == roomTypeName).ElementAt(0);

                if (currentRoom.PricePerNight == 0)
                {
                    currentRoom.SetPrice(price);
                    return String.Format(OutputMessages.PriceSetSuccessfully, roomTypeName, hotelName);
                }
                else
                {
                    return "Price is already set!";
                }

            }
        }

        public string UploadRoomTypes(string hotelName, string roomTypeName)
        {
            if (hotels.All().FirstOrDefault(x => x.FullName == hotelName) == null)
            {
                return $"Profile {hotelName} doesn’t exist!";
            }

            Hotel hotel = hotels.All().Where(x => x.FullName == hotelName).ElementAt(0) as Hotel;

            if (hotel.Rooms.Select(roomTypeName) != null)
            {
                return OutputMessages.RoomTypeAlreadyCreated;
            }

            if (roomTypeName == nameof(Apartment))
            {
                var room = new Apartment();
                hotel.Rooms.AddNew(room);
            }
            else if (roomTypeName == nameof(DoubleBed))
            {
                var room = new DoubleBed();
                hotels.Select(hotelName).Rooms.AddNew(room);
            }
            else if (roomTypeName == nameof(Studio))
            {
                var room = new Studio();
                hotels.Select(hotelName).Rooms.AddNew(room);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.RoomTypeIncorrect);
            }

            return String.Format(OutputMessages.RoomTypeAdded, roomTypeName, hotelName);
        }
    }
}
