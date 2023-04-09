using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Modals
{
    public class Product
    {
        public int ProductId { get; set; }

        public string SupplierId { get; set; }

        public string Information { get; set; }

        public int Quantity { get; set; }

        public DateTime? SupplyDate { get; set; }
    }
}
