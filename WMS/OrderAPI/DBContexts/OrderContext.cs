using Microsoft.EntityFrameworkCore;
using OrderAPI.Entities;

namespace OrderAPI.DBContexts
{
    public class OrderContext : DbContext
    {
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Product>Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnmodelCreating(ModelBuilder modelBuilder)
        { 
        }
    }
}
