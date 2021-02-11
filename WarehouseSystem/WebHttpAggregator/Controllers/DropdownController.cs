using CommonObjects.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.HttpAggregator.Util;

namespace Web.HttpAggregator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DropdownController : ControllerBase
    {

        [HttpGet, Route("GetWarehouses")]
        public async Task<IEnumerable<DropdownDto>> GetWarehouses()
        {
            var warehouses = await HttpCall.GetRequest<List<DropdownDto>>("https://localhost:44369/Dropdown/GetWarehouses");
            var products = await HttpCall.GetRequest<List<DropdownDto>>("https://localhost:44369/Dropdown/GetProducts");
            warehouses.AddRange(products);
            return warehouses;
        }
    }
}
