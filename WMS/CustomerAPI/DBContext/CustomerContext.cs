using CustomerAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerAPI.DBContext
{
    public class CustomerContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Location> Locations { get; set; }

        protected override void OnmodelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
