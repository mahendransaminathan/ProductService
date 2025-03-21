using ProductService.Models.Entities;
using ProductService.Providers;


namespace ProductService.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductProvider _provider;

        public ProductService(ProductProvider provider)
        {
            _provider = provider;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _provider.GetProducts();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _provider.GetProduct(id);
        }

        // ✅ Update Product in MongoDB
        public async Task UpdateProduct(Product product)
        {            
            await _provider.UpdateProduct(product);
        }

        // ✅ Create Product in MongoDB
        public async Task CreateProduct(Product product)
        {
            await _provider.CreateProduct(product);
        }

        // ✅ Delete Product from MongoDB
        public async Task DeleteProduct(string id)
        {
            await _provider.DeleteProduct(id);
        }

        // ✅ Delete Product from MongoDB by integer ID
        public async Task DeleteProduct(int id)
        {
            var stringId = id.ToString();
            await _provider.DeleteProduct(stringId);
        }
    }
}