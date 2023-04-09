using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Service
{
    public class ProductService : IProductServicecs
    {
        public Modals.Product CreateProduct(Modals.Product product)
        {
            Data.ProductDAO.Products.Add(product);
            return product;
        }

        public string DeleteCase(int productId)
        {
            Modals.Product getProds =  Data.ProductDAO.Products.Find(prod => prod.ProductId == productId);
            Data.ProductDAO.Products.Remove(getProds);
            return productId.ToString();
        }

        public List<Modals.Product> GetAllProducts()
        {
            return Data.ProductDAO.Products;
        }

        public Modals.Product GetProductByProductId(int prodctId)
        {
            return Data.ProductDAO.Products.FirstOrDefault(prod => prod.ProductId == prodctId);
        }
    }
}
