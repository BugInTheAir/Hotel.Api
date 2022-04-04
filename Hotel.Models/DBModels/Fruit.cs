using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsShop.Models.DBModels
{
    public class Fruit
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get;set; }
        [BsonElement("FruitName")]
        public string? FruitName { get; set; } = null!;
        [BsonElement("Images")]
        public IEnumerable<String> Images { get; set; } = null!;
        [BsonElement("Price")]
        public double? Price { get; set; } = null!;
        [BsonElement("Description")]
        public string? Description { get; set; } = null!;
    }
}
