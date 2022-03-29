using Hotel.Models.DTO;
using Hotel.Models.Mapper;
using Hotel.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomServices _roomServices;
        private readonly IRoomMapper _roomMapper;

        public RoomController(IRoomServices roomServices, IRoomMapper roomMapper)
        {
            _roomServices = roomServices;
            _roomMapper = roomMapper;
        }

        [HttpGet]
        public async Task<IEnumerable<RoomDto>> GetRooms() => _roomMapper.ToDtos(await _roomServices.GetRoomsAsync());
    }
}
