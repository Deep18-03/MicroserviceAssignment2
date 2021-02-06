using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseAPI.Entities
{
    public class Warehouse
    {
        public int id { get; set; }
        public Guid Externalid { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public long Locationid { get; set; }
        public  Location Location { get; set; }
    }
}
