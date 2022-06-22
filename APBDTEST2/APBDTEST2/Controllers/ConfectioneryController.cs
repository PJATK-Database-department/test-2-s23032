using APBDTEST2.DTO_s;
using APBDTEST2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace APBDTEST2.Controllers
{
    [Route("api/confectionery")]
    [ApiController]
    public class ConfectioneryController : ControllerBase
    {

        private readonly MyContext context;

        public ConfectioneryController(MyContext context)
        {
            this.context = context;
        }
        [HttpGet("confectionery/{clientId}")]
        public async Task<IActionResult> GetOrdersAsync(int clientId)
        {
            try
            {
                var orders = context.ClientOrders.Where(e => e.IdClient == clientId).Select(e => new OrdersDto
                {
                    IdClientOrder = e.IdClient,
                    OrderDate = e.OrderDate,
                    CompletionDate = e.CompletionDate,
                    Comments = e.Comments,
                    Confectioneries = context.ConfOrders.Where(d => d.IdClientOrder == e.IdClientOrder).ToList()
                }) ;
                return Ok(orders);
            } catch (Exception) {
                return BadRequest("some fields are missing");
            }
        }
    }
}
