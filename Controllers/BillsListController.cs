using InvoiceApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillsListController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddBill(BillsList billsList)
        {
            return Ok();
        }
    }
}
