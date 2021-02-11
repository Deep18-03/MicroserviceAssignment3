using OrderEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderAPI.Services
{
    public class OrderService
    {
        public IEnumerable<Order> GetOrders(long? id = null)
        {
            var orders = new List<Order>();
            var warehouses = GetWarehouses();
            if (id != null)
            {
                warehouses = warehouses.Where(r => r.WarehouseId == id);
            }
            foreach (var warehouse in warehouses)
            {
                for (int i = 1; i <= 3; i++)
                {
                    orders.Add(new Order
                    {
                        Id = i,
                        Number = $"{warehouse.Name}_OrderNumber_{i}",
                        Amount = (double)i * 4.96,
                        Product = $"Food_{i}",
                        ProductId = i,
                        PlaceOn = DateTime.Now.AddMinutes(i * (-10)),
                        Quantity = i,
                        WarehouseId = warehouse.WarehouseId,
                        Warehouse = warehouse
                    });
                }
            }
            return orders;
        }

        private IEnumerable<Warehouse> GetWarehouses()
        {
            var warehouses = new List<Warehouse>();
            for (int i = 1; i <= 3; i++)
            {
                warehouses.Add(new Warehouse
                {
                    Id = i,
                    WarehouseId = i,
                    Name = $"Warehouse_{i}",
                    Address = $"Address_{i}"
                });
            }
            return warehouses;
        }
    }
}
