using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EcommerceMVC.Enums;

namespace EcommerceMVC.Models.DTO.Customer
{
    public class CustomerDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public UserRoleType UserRole { get; set; }

    }
}