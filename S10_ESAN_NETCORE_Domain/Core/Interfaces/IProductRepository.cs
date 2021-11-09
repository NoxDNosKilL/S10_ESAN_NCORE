using S10_ESAN_NETCORE.Domain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace S10_ESAN_NETCORE.Domain.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<bool> Delete(int id);
        Task<Product> GetProductById(int id);
        Task<IEnumerable<Product>> GetProducts();
        Task<bool> Insert(Product product);
        Task<bool> Update(Product product);
    }
}