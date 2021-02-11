using Microsoft.AspNetCore.Mvc;

using OrderAPI.Services;
using OrderEntities.Entities;
using System.Collections.Generic;

namespace OrderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {


        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            return new OrderService().GetOrders();
        }


        [HttpGet, Route("GetOrder/{id}")]
        public IEnumerable<Order> GetOrder(long id)
        {
            return new OrderService().GetOrders(id: id);
        }

    }
}
