using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Services;
using RestaurantEntities.Entities;
using System.Collections.Generic;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        [HttpGet, Route("GetProducts")]
        public IEnumerable<Product> Get()
        {
            return new ProductService().GetProducts();
        }
    }
}
