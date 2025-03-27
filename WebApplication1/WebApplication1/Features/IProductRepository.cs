using WebApplication1.Features.Commands;

namespace WebApplication1.Features
{
    public interface IProductRepository
    {
        Task<Product> GetProductByName(string name);
    }
}
