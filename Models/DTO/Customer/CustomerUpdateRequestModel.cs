using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EcommerceMVC.Models.DTO.Customer
{
    public class CustomerUpdateRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DisplayName("Password")]
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
