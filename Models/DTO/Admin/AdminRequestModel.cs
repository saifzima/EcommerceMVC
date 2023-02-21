using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceMVC.Enums;

namespace EcommerceMVC.Models.DTO.Admin
{
    public class AdminRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public UserRoleType userRole { get; set; }
    }

}