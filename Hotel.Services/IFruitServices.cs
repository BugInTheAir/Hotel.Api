using FruitsShop.Models.DBModels;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FruitsShop.Services
{
    public interface IFruitsServices
    {
        public Task<IEnumerable<Fruit>> GetFruitsAsync();
    }
}