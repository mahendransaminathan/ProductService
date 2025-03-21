using ProductService.Models.Entities;

namespace ProductService.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task UpdateProduct(Product product);
        Task CreateProduct(Product product);
        Task DeleteProduct(int id);
    }
}