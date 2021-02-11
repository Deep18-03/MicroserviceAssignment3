using CommonObjects.Models;
using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Services;
using System.Collections.Generic;
using System.Linq;
namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DropdownController : ControllerBase
    {

        /// GetProducts
        [HttpGet, Route("GetProducts")]
        public IEnumerable<DropdownDto> GetProducts()
        {
            return new ProductService().GetProducts().Select(r => new DropdownDto { Id = r.Id, Name = r.Name });
        }
        /// GetWarehouses
        [HttpGet, Route("GetWarehouses")]
        public IEnumerable<DropdownDto> GetWarehouses()
        {
            return new WarehouseService().GetWarehouses().Select(r => new DropdownDto { Id = r.Id, Name = r.Name });
        }
    }
}
