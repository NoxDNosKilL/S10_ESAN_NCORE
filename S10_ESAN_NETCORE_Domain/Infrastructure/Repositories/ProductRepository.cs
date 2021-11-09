using Microsoft.EntityFrameworkCore;
using S10_ESAN_NETCORE.Domain.Core.Entities;
using S10_ESAN_NETCORE.Domain.Core.Interfaces;
using S10_ESAN_NETCORE.Domain.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10_ESAN_NETCORE.Domain.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly SalesContext _context;
        public ProductRepository(SalesContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Product.ToListAsync();
        }
        public async Task<Product> GetProductById(int id)
        {
            return await _context.Product.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        public async Task<bool> Insert(Product product)
        {
            await _context.Product.AddAsync(product);
            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }
        public async Task<bool> Update(Product product)
        {
            var productNow = await _context.Product.FindAsync(product.Id);
            productNow.Id = product.Id;
            productNow.ProductName = product.ProductName;
            productNow.SupplierId = product.SupplierId;
            productNow.UnitPrice = product.UnitPrice;
            productNow.Package = product.Package;
            productNow.IsDiscontinued = product.IsDiscontinued;

            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }
        public async Task<bool> Delete(int id)
        {
            var productNow = await _context.Product.FindAsync(id);
            if (productNow == null)
            {
                return false;
            }
            _context.Product.Remove(productNow);

            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

    }
}
