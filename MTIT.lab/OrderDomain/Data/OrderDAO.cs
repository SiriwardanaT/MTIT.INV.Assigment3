using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderDomain.Data
{
    public static class OrderDAO
    {
        public static List<Modals.Order> Orders = new List<Modals.Order>()
        {
            new Modals.Order(){ OrderId=10,OrderDate=DateTime.Now, OrderAmont=2000.00,UserId="U12" },
            new Modals.Order(){ OrderId=10,OrderDate=DateTime.Now, OrderAmont=2000.00,UserId="U12" }
        };
    }
}
