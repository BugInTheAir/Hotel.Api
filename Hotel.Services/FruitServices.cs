using FruitsShop.Models.DBModels;
using FruitsShop.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FruitsShop.Services
{
    public class FruitServices : IFruitsServices
    {
        private readonly IFruitRepository _fruitRepo;

        public FruitServices(IFruitRepository roomRepo)
        {
            _fruitRepo = roomRepo;
        }

        public Task<IEnumerable<Fruit>> GetFruitsAsync()
        {
            return _fruitRepo.GetAysnc();
        }
    }
}
