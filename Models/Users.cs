using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EcommerceMVC.Enums;

namespace EcommerceMVC.Models
{
    public class User : BaseEntity
    {
        public int Id{get; set;}
        public Customers Customer { get; set; }
        public DeliveryMan DeliveryMan { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public UserRoleType Role { get; set; }
    }
}