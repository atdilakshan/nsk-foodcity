namespace NSK_FoodCity.Entities
{
    public class Address
    {
        public Guid Id { get; set; }
        public int HouseNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public Guid CustomerId { get; set; } // Foreign Key

        public Customer Customer { get; set; } // Navigation property
    }
}
