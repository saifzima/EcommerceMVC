using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.Models.DTO.DeliveryManDTO
{
    public class CreateDeliveryManRequestModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Key]
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string PlateNumber { get; set; }
        [Required]
        public string PassWord { get; set; }
        public string CustomerAddress { get; set; }
    }
}
