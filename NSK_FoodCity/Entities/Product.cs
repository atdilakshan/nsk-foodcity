namespace NSK_FoodCity.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public ICollection<Order> Orders { get; set; } // Navigation property
    }
}
