using RestaurantEntities.Entities;
using System.Collections.Generic;
namespace RestaurantAPI.Services
{
    public class WarehouseService
    {
        public List<Warehouse> GetWarehouses()
        {
            var warehouses = new List<Warehouse>();
            for (int i = 1; i <= 5; i++)
            {
                warehouses.Add(new Warehouse
                {
                    Id = i,
                    Name = $"Restaurant_{i}",
                    Address = new Address
                    {
                        Id = i,
                        Street = $"Street_{i}",
                        Number = i,
                        City = $"City_{i}",
                        State = $"State_{i}",
                        Pincode = $"Pincode_{i}",
                        Country = $"Country_{i}"
                    }

                });
            }
            return warehouses;
        }


        public WarehouseList GetList(long id)
        {
            var warehouse = GetWarehouses().Find(r => r.Id == id);
            var list = new WarehouseList()
            {
                Id = 1,
                Warehouse = warehouse,
                WarehouseId = warehouse.Id
            };

            var products = new ProductService().GetProducts();
            for (int i = 0; i < products.Count; i++)
            {
                var product = products[i];
                list.Products.Add(new WarehouseProduct
                {
                    Product = product,
                    ProductId = product.Id
                });
            }
            return list;
        }
    }
}
