using Hotel.Models.DBModels;
using Hotel.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel.Services
{
    public class RoomServices : IRoomServices
    {
        private readonly IRoomRepository _roomRepo;

        public RoomServices(IRoomRepository roomRepo)
        {
            _roomRepo = roomRepo;
        }

        public Task<IEnumerable<Room>> GetRoomsAsync()
        {
            return _roomRepo.GetAysnc();
        }
    }
}
