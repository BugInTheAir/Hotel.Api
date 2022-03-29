using Hotel.Models.DBModels;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel.Services
{
    public interface IRoomServices
    {
        public Task<IEnumerable<Room>> GetRoomsAsync();
    }
}