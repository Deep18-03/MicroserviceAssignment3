namespace RestaurantEntities.Entities
{
    public class Warehouse
    {
        public Warehouse()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public Address Address { get; set; }
    }
}
