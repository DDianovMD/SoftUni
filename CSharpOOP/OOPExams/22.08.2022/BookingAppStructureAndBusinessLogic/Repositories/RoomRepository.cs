using BookingApp.Models.Rooms.Contracts;
using BookingApp.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace BookingApp.Repositories
{
    public class RoomRepository : IRepository<IRoom>
    {
        private List<IRoom> roomsCollection;

        public RoomRepository()
        {
            this.roomsCollection = new List<IRoom>();
        }
        public void AddNew(IRoom model)
        {
            this.roomsCollection.Add(model);
        }

        public IReadOnlyCollection<IRoom> All()
        {
            return roomsCollection.AsReadOnly();
        }

        public IRoom Select(string criteria)
        {
            return roomsCollection.FirstOrDefault(x => x.GetType().Name == criteria);
        }
    }
}
