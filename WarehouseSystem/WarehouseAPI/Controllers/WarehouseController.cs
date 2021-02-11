using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Services;
using RestaurantEntities.Entities;
using System.Collections.Generic;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WarehouseController : ControllerBase
    {
        [HttpGet, Route("GetWarehouses")]
        public IEnumerable<Warehouse> Get()
        {
            return new WarehouseService().GetWarehouses();
        }

        [HttpGet, Route("GetList/{id}")]
        public WarehouseList GetWarehouseList(long id)
        {
            return new WarehouseService().GetList(id: id);
        }
    }
}
