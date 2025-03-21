

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProductService.Models.Entities
{
    public class Product
    {
        
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        [BsonElement("productName")]
        public required string ProductName { get; set; }

        [BsonElement("companyName")]
        public required string CompanyName { get; set; }

        [BsonElement("category")]
        public required string Category { get; set; }

        [BsonElement("licenseType")]
        public required string LicenseType { get; set; }
        
        [BsonElement("price")]
        public decimal Price { get; set; }

        [BsonElement("currency")]
        public required string Currency { get; set; }

        [BsonElement("quantity")]
        public required decimal Quantity { get; set; }

        [BsonElement("supplier")]
        public required string Supplier { get; set; }

        [BsonElement("availabilityStatus")]
        public required bool AvailabilityStatus { get; set; }

        [BsonElement("deliveryOptions")]
        public required string DeliveryOptions { get; set; }

        [BsonElement("brandName")]
        public required string BrandName { get; set; }

        [BsonElement("modelnumber")]
        public required decimal ModelNumber { get; set; }

        [BsonElement("discount")]
        public required decimal Discount { get; set; }

        [BsonElement("countryOfOrigin")]
        public required string CountryOfOrigin { get; set; }    
    }
}