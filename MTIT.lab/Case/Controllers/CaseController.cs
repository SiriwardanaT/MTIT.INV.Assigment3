using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Case.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseController : ControllerBase
    {
        Service.ICaseServicecs _caseService;
        public CaseController(Service.ICaseServicecs caseService) {
            _caseService = caseService;
        }
        // GET: api/<InvoiceController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_caseService.getAllCases());
        }

        // GET api/<InvoiceController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Modals.Case _case = _caseService.getCaseByCaseId(id);
            if (_case != null)
            {
                return Ok(_case);
            }
            else {
                return NotFound("No Case found ");
            }
        }

        // POST api/<InvoiceController>
        [HttpPost]
        public IActionResult Post(Modals.Case invoice)
        {
            return Ok(_caseService.CreateCase(invoice));
        }

        // DELETE api/<InvoiceController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Id = _caseService.deleteCase(id);
            return Ok("Case " + Id + "deleted");
        }
    }
}
