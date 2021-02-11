using System;

namespace OrderEntities.Entities
{
    public class Order
    {
        public long Id { get; set; }
        public string Number { get; set; }

        public DateTime PlaceOn { get; set; }
        public long WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        public long ProductId { get; set; }
        public string Product { get; set; }

        public int Quantity { get; set; }
        public double Amount { get; set; }
    }
}
