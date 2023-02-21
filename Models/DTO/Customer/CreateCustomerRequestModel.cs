using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.Models.DTO.Customer
{
    public class CreateCustomerRequestModel
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DisplayName("Password")]
        public string Password { get; set; }
        [Required]
        [DisplayName("Confirm Password")]
        [Compare("Password", ErrorMessage = "pass not match")]
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

    }
}
