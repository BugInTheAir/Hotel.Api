using FruitsShop.Models.DBModels;
using FruitsShop.Models.DTO;
using System.Collections;
using System.Collections.Generic;

namespace FruitsShop.Models.Mapper
{
    public interface IFruitMapper
    {
        public IEnumerable<FruitDto> ToDtos(IEnumerable<Fruit> rooms);
        public FruitDto ToDto(Fruit room);
    }
}