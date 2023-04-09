using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Data
{
    public static class ProductDAO
    {
        public static List<Modals.Product> Products = new List<Modals.Product>()
        {
            new Modals.Product(){ ProductId=10,SupplyDate=DateTime.Now,Information="O13",SupplierId="U12" ,Quantity=1},
            new Modals.Product(){ ProductId=13,SupplyDate=DateTime.Now,Information="O13",SupplierId="U12" ,Quantity=1 }
        };
    }
}
