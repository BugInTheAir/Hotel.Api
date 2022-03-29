using Hotel.Models.DBModels;
using Hotel.Models.DTO;
using System.Collections;
using System.Collections.Generic;

namespace Hotel.Models.Mapper
{
    public interface IRoomMapper
    {
        public IEnumerable<RoomDto> ToDtos(IEnumerable<Room> rooms);
        public RoomDto ToDto(Room room);
    }
}