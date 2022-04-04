using FruitsShop.Models.DTO;
using FruitsShop.Models.Mapper;
using FruitsShop.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FruitsShop.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        private readonly IFruitsServices _fruitServices;
        private readonly IFruitMapper _roomMapper;

        public FruitsController(IFruitsServices roomServices, IFruitMapper roomMapper)
        {
            _fruitServices = roomServices;
            _roomMapper = roomMapper;
        }

        [HttpGet]
        public async Task<IEnumerable<FruitDto>> GetRooms() => _roomMapper.ToDtos(await _fruitServices.GetFruitsAsync());
    }
}
