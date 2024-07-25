using System.ComponentModel.DataAnnotations;

namespace NSK_FoodCity.Models
{
    public class CustomerResponseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhonNumber { get; set; }
        public string Email { get; set; }
    }
}
