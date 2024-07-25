using System.ComponentModel.DataAnnotations;

namespace NSK_FoodCity.Models
{
    public class CustomerRequestModel
    {
        public Guid? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string PhonNumber { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
