using Hotel.Models.DBModels;
using Hotel.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models.Mapper
{
    public class RoomMapper : IRoomMapper
    {
        public RoomDto ToDto(Room room)
        {
            return new RoomDto()
            {
                Id = room.Id,
                RoomNumber = room.RoomNumber,
                Description = room.Description,
                Images = room.Images,
                Price = room.Price
            };
        }

        public IEnumerable<RoomDto> ToDtos(IEnumerable<Room> rooms)
        {
            return rooms.Select(x => ToDto(x));
        }
    }
}
