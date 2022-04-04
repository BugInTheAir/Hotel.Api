using FruitsShop.Models.DBModels;
using FruitsShop.Repository.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FruitsShop.Repository
{
    public class FruitRepository : IFruitRepository
    {
        private readonly IMongoCollection<Fruit> _fruitsCollection;
        public FruitRepository(IOptions<DatabaseSettings> hotelDatabaseSettings)
        {
            var mongoClient = new MongoClient(hotelDatabaseSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(hotelDatabaseSettings.Value.DatabaseName);
            _fruitsCollection = mongoDatabase.GetCollection<Fruit>(hotelDatabaseSettings.Value.FruitsCollectionName);
        }

        public async Task<IEnumerable<Fruit>> GetAysnc() => (await(await this._fruitsCollection.FindAsync(_ => true)).ToListAsync());
    }
}
