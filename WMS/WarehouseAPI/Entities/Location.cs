using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseAPI.Entities
{
    public class Location
    {
        public int id { get; set; }
        public Guid Externalid { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public string Country { get; set; }
    }
}
