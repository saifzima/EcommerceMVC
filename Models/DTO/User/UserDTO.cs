using EcommerceMVC.Enums;

namespace EcommerceMVC.Models.DTO.User
{
    public class UserDTO
    {
        public int Id{get;set;}
        public string Email { get; set; }
        public UserRoleType Role { get; set; }
    }
}
