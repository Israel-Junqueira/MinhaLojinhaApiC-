using MongoDB.Bson;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace LojinhaServer.Collections
{
    [BsonIgnoreExtraElements]
    [Table("products")]
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        
        [BsonElement("Name")]
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [BsonElement("Description")]
        [JsonPropertyName("Description")]
        public string Description { get; set; }
        
        [BsonElement("Price")]
        public string Price { get; set; }

        
      
        [BsonElement("Categories")]
        public List<string> Categories { get; set; }

        
       
        [BsonElement("OffPrice")]
        public string OffPrice { get; set; }
        
        [BsonElement("Tags")]
        public List<string> Tags { get; set; }

        
        [BsonElement("Brand")]
        public string Brand { get; set; }
    }
}