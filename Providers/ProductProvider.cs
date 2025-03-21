using ProductService.Models.Entities;
using ProductService.Providers;
using MongoDB.Driver;
namespace ProductService.Providers
{
    public class ProductProvider : IProductProvider
    {
        private readonly IMongoCollection<Product> _products;
        

        public ProductProvider(IMongoDatabase database)
        {
            _products = database.GetCollection<Product>("Products");
        }
        
        // Get all products
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _products.Find(_ => true).ToListAsync();
        }

        // Get product by ID
        
        public async Task<Product> GetProduct(int id)
        {
            return await _products.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        // Create a product
        public async Task CreateProduct(Product product)
        {
            await _products.InsertOneAsync(product);
        }

        // Update a product
        public async Task UpdateProduct(Product product)
        {
            await _products.ReplaceOneAsync(p => p.Id == product.Id, product);
        }

        public async Task UpdateProduct(string id, Product product)
        {
            if (int.TryParse(id, out int parsedId))
            {
                product.Id = parsedId;
                await UpdateProduct(product);
            }
        }

        // Delete a product
        public async Task DeleteProduct(string id)
        {
            if (int.TryParse(id, out int parsedId))
            {
                await DeleteProduct(parsedId);
            }
        }

        public async Task DeleteProduct(int id)
        {
            await _products.DeleteOneAsync(p => p.Id == id);
        }
        

    }
 
}