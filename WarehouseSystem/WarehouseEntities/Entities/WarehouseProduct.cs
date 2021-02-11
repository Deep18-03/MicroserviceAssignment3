using System.Collections.Generic;

namespace RestaurantEntities.Entities
{
    public class WarehouseProduct
    {
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }

    public class WarehouseList
    {
        public WarehouseList()
        {
            Products = new List<WarehouseProduct>();
        }
        public long Id { get; set; }
        public long WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        public List<WarehouseProduct> Products { get; set; }
    }
}
