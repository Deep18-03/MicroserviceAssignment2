using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseAPI.Entities
{
    public class Product
    {
        public int id { get; set; }
        public Guid Externalid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int Warehouseid { get; set; }
    

    }
    public enum Category
    {
        Mobile,
        Laptop,
        Desktop,
        Gadgets
    }


}
