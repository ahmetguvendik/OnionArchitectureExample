using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Domain.Entities;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace ETicaret.Application.Abstractions
{
    public interface IProductService
    {
        public Task<List<Domain.Entities.Product>> GetProducts();
        public Task<Domain.Entities.Product> GetProductById(int id);
    }
}
