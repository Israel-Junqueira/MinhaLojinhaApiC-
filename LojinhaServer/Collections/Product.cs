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
        public decimal Price { get; set; }
      
        [BsonElement("Categories")]
        public List<string> Categories { get; set; }

        
       
        [BsonElement("OffPrice")] //OffPrice
        public decimal OffPrice { get; set; }
        
        [BsonElement("Tags")] //tag
        public List<string> Tags { get; set; }

        
        [BsonElement("Brand")] //marca
        public string Brand { get; set; }
    }
}