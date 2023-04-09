using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Service
{
    public interface IProductServicecs
    {
        Modals.Product CreateProduct(Modals.Product product);

        List<Modals.Product> GetAllProducts();

        Modals.Product GetProductByProductId(int productId);

        string DeleteCase(int productId);
    }
}
