using Microsoft.EntityFrameworkCore;
using WarehouseAPI.Entities;

namespace WarehouseAPI.DBContexts
{
    public class WarehouseContext:DbContext
    {
        public DbSet<Warehouse>Warehouses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnmodelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
