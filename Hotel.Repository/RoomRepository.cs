using Hotel.Models.DBModels;
using Hotel.Repository.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly IMongoCollection<Room> _roomsCollection;
        public RoomRepository(IOptions<HotelDatabaseSettings> hotelDatabaseSettings)
        {
            var mongoClient = new MongoClient(hotelDatabaseSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(hotelDatabaseSettings.Value.DatabaseName);
            _roomsCollection = mongoDatabase.GetCollection<Room>(hotelDatabaseSettings.Value.RoomsCollectionName);
        }

        public async Task<IEnumerable<Room>> GetAysnc() => (await(await this._roomsCollection.FindAsync(_ => true)).ToListAsync());
    }
}
