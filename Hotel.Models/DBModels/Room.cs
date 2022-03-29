using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models.DBModels
{
    public class Room
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get;set; }
        [BsonElement("RoomNumber")]
        public string? RoomNumber { get; set; } = null!;
        [BsonElement("RoomImages")]
        public IEnumerable<String> Images { get; set; } = null!;
        [BsonElement("Price")]
        public double? Price { get; set; } = null!;
        [BsonElement("Description")]
        public string? Description { get; set; } = null!;
    }
}
