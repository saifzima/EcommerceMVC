using EcommerceMVC.Enums;
using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.Models.DTO.DeliveryMan
{
    public class DeliveryManDTO
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
        public string DeliveryManId { get; set; }
        [Required]
        public string PassWord { get; set; }
        public string CustomerAddress { get; set; }
        public UserRoleType UserRole { get; set; }
    }
}
