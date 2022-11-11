using BookingApp.Models.Bookings;
using BookingApp.Models.Bookings.Contracts;
using BookingApp.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace BookingApp.Repositories
{
    public class BookingRepository : IRepository<IBooking>
    {
        private List<IBooking> bookingsCollection;
        public BookingRepository()
        {
            this.bookingsCollection = new List<IBooking>();
        }
        public void AddNew(IBooking model)
        {
            this.bookingsCollection.Add(model);
        }

        public IReadOnlyCollection<IBooking> All()
        {
            return this.bookingsCollection.AsReadOnly();
        }

        public IBooking Select(string criteria)
        {
            return this.bookingsCollection.FirstOrDefault(x => x.BookingNumber == int.Parse(criteria));
        }
    }
}
