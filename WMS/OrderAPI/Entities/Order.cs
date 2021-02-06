using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Entities
{
    public class Order
    {
        public int id { get; set; }
        public Guid Externalid { get; set; }
        public int Warehouseid { get; set; }
        public Warehouse Warehouse { get; set; }
        public int Productid { get; set; }

        public Product Product { get; set; }
        public int Customerid { get; set; }'
        public Customer Customer { get; set; }
    }
}
