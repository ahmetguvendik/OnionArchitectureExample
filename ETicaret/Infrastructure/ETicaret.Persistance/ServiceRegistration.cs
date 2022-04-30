using ETicaret.Application.Abstractions;
using ETicaret.Persistance.Concretes;
using ETicaret.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddDbContext<ETicaretContext>(opt =>
            {
                opt.UseSqlServer("Server=//; Database=ETicaretDB; Trusted_Connection=True");
            });
        }
    }
}
