using ProductService.Models.Entities;

namespace ProductService.Providers
{
    public interface IProductProvider
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task UpdateProduct(Product product);
        Task CreateProduct(Product product);
        Task DeleteProduct(int id);
    }
}