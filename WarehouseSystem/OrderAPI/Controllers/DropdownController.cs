using CommonObjects.Models;
using Microsoft.AspNetCore.Mvc;
using OrderAPI.Services;
using System.Collections.Generic;
using System.Linq;
namespace OrderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DropdownController : ControllerBase
    {
        /// Get orders
        [HttpGet, Route("GetOrders")]
        public IEnumerable<DropdownDto> GetOrders()
        {
            return new OrderService().GetOrders().Select(r => new DropdownDto { Id = r.Id, Name = r.Number });
        }
    }
}
