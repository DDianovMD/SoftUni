using BookingApp.Models.Hotels.Contacts;
using BookingApp.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace BookingApp.Repositories
{
    public class HotelRepository : IRepository<IHotel>
    {
        private List<IHotel> hotelsRepository;
        public HotelRepository()
        {
            this.hotelsRepository = new List<IHotel>();
        }
        public void AddNew(IHotel model)
        {
            this.hotelsRepository.Add(model);
        }

        public IReadOnlyCollection<IHotel> All()
        {
            return this.hotelsRepository.AsReadOnly();
        }

        public IHotel Select(string criteria)
        {
            return this.hotelsRepository.FirstOrDefault(x => x.FullName == criteria);
        }
    }
}
