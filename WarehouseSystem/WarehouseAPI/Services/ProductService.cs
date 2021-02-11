using RestaurantEntities.Entities;
using RestaurantEntities.Enum;
using System.Collections.Generic;

namespace RestaurantAPI.Services
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            var products = new List<Product>();
            for (int i = 1; i <= 5; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = $"Product_{i}",
                    Category = Categoryenum.Mobile,
                });
            }
            return products;
        }
    }
}
