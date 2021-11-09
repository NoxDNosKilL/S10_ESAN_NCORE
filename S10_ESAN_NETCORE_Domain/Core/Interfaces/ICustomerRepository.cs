using S10_ESAN_NETCORE.Domain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace S10_ESAN_NETCORE.Domain.Core.Interfaces
{
    public interface ICustomerRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> GetCustomerById(int id);
        Task<bool> Insert(Customer customer);
        Task<bool> Update(Customer customer);
    }
}