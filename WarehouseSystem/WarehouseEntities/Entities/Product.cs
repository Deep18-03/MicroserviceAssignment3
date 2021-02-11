using RestaurantEntities.Enum;

namespace RestaurantEntities.Entities
{
    public class Product
    {
        public Product()
        {
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public Categoryenum Category { get; set; }
        //public string TypeName => Type.ToString();
    }
}