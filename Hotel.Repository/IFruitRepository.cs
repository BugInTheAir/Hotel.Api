using FruitsShop.Models.DBModels;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FruitsShop.Repository
{
    public interface IFruitRepository
    {
        public Task<IEnumerable<Fruit>> GetAysnc();
    }
}