using FruitsShop.Models.DBModels;
using FruitsShop.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsShop.Models.Mapper
{
    public class FruitMapper : IFruitMapper
    {
        public FruitDto ToDto(Fruit room)
        {
            return new FruitDto()
            {
                Id = room.Id,
                FruitName = room.FruitName,
                Description = room.Description,
                Images = room.Images,
                Price = room.Price
            };
        }

        public IEnumerable<FruitDto> ToDtos(IEnumerable<Fruit> rooms)
        {
            return rooms.Select(x => ToDto(x));
        }
    }
}
