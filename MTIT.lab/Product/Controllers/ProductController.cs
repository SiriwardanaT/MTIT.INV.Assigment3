using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        Service.IProductServicecs _productService;
        public ProductController(Service.IProductServicecs productService) {
            _productService = productService;
        }
        // GET: api/<InvoiceController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.GetAllProducts());
        }

        // GET api/<InvoiceController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Modals.Product _case = _productService.GetProductByProductId(id);
            if (_case != null)
            {
                return Ok(_case);
            }
            else {
                return NotFound("No Products found ");
            }
        }

        // POST api/<InvoiceController>
        [HttpPost]
        public IActionResult Post(Modals.Product invoice)
        {
            return Ok(_productService.CreateProduct(invoice));
        }

        // DELETE api/<InvoiceController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Id = _productService.DeleteCase(id);
            return Ok("Product " + Id + "deleted");
        }
    }
}
