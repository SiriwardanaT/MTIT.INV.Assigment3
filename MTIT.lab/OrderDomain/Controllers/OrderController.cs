using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderDomain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        Service.IOrderServicecs _orderService;
        public OrderController(Service.IOrderServicecs orderService) {
            _orderService = orderService;
        }
        // GET: api/<InvoiceController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_orderService.GetAllOrders());
        }

        // GET api/<InvoiceController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Modals.Order order = _orderService.GetOrdersOrderId(id);
            if (order != null)
            {
                return Ok(order);
            }
            else {
                return NotFound("No Order found ");
            }
        }

        // POST api/<InvoiceController>
        [HttpPost]
        public IActionResult Post(Modals.Order order)
        {
            return Ok(_orderService.CreateOrder(order));
        }

        // DELETE api/<InvoiceController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Id = _orderService.DeleteOrder(id);
            return Ok("Order " + Id + "deleted");
        }
    }
}
