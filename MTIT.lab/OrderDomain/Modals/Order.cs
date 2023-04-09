using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderDomain.Modals
{
    public class Order
    {
        public int OrderId { get; set; }

        public string UserId { get; set; }

        public double OrderAmont { get; set; }

        public DateTime? OrderDate { get; set; }
    }
}
