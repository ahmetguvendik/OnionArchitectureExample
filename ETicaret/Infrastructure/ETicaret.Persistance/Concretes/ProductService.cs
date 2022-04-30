using ETicaret.Application.Abstractions;
using ETicaret.Persistance.Contexts;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistance.Concretes
{
    public class ProductService : IProductService
    {
        private readonly ETicaretContext _context;
        public ProductService(ETicaretContext context)
        {
            _context = context;
        }

        public Task<List<Domain.Entities.Product>> GetProducts()
        {
            return _context.Products.ToListAsync();
        }

        async Task<Domain.Entities.Product> IProductService.GetProductById(int id)
        {
            return await _context.Products.SingleOrDefaultAsync(p => p.Id == id);
        }


    }
}
