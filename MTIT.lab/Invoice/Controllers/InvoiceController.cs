using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Invoice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        Service.IInvoiceServicecs _invoiceService;
        public InvoiceController(Service.IInvoiceServicecs invoiceService) {
            _invoiceService = invoiceService;
        }
        // GET: api/<InvoiceController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_invoiceService.GetAllInvoices());
        }

        // GET api/<InvoiceController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            Modals.Invoice invoice = _invoiceService.GetInvoiceByOrderId(id);
            if (invoice != null)
            {
                return Ok(invoice);
            }
            else {
                return NotFound("No Invoice found ");
            }
        }

        // POST api/<InvoiceController>
        [HttpPost]
        public IActionResult Post(Modals.Invoice invoice)
        {
            return Ok(_invoiceService.CreateInvoice(invoice));
        }

        // DELETE api/<InvoiceController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Id =  _invoiceService.DeleteInvoice(id);
            return Ok("Invoice " + Id + "deleted");
        }
    }
}
