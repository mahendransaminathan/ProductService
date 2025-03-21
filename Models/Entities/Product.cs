
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ProductService.Models.Entities
{
    public class Product
    {
        
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("productName")]
        public required string ProductName { get; set; }

        [JsonProperty("companyName")]
        public required string CompanyName { get; set; }

        [JsonProperty("category")]
        public required string Category { get; set; }

        [JsonProperty("licenseType")]
        public required string LicenseType { get; set; }
        
        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("currency")]
        public required string currency { get; set; }

        [JsonProperty("quantity")]
        public required decimal quantity { get; set; }

        [JsonProperty("supplier")]
        public required string supplier { get; set; }

        [JsonProperty("availabilityStatus")]
        public required bool AvailabilityStatus { get; set; }

        [JsonProperty("deliveryOptions")]
        public required string DeliveryOptions { get; set; }

        [JsonProperty("brandName")]
        public required string BrandName { get; set; }

        [JsonProperty("modelnumber")]
        public required decimal ModelNumber { get; set; }

        [JsonProperty("discount")]
        public required decimal Discount { get; set; }

        [JsonProperty("countryoforigin")]
        public required string CountryOfOrigin { get; set; }    
    }
}