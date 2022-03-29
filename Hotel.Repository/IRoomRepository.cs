using Hotel.Models.DBModels;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel.Repository
{
    public interface IRoomRepository
    {
        public Task<IEnumerable<Room>> GetAysnc();
    }
}