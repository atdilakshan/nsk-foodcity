namespace NSK_FoodCity.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime OrderedDate { get; set; }
        public Guid CustomerId { get; set; } // Foreign Key
        public Guid ProductId { get; set; } // Foreign Key
        public int Quantity { get; set; }

        public Customer Customer { get; set; } // Navigation property
        public Product Product { get; set; } // Navigation property
    }
}
