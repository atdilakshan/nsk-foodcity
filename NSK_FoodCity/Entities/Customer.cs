namespace NSK_FoodCity.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhonNumber { get; set; }
        public string Email { get; set; }

        public ICollection<Address> Addresses { get; set; } // Navigation property
        public ICollection<Order> Orders { get; set; } // Navigation property
    }
}
