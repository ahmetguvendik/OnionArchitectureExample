using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistance.Contexts
{
    public class ETicaretContext : DbContext
    {
        public ETicaretContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new Product{Id=1,Name="Bilgisayar",Price=10000,Stock=200},
                new Product{Id=2,Name="Telefon",Price=5000,Stock=500},
                new Product{Id=3,Name="Saat",Price=200,Stock=1000}
            });
        }

    }
}
