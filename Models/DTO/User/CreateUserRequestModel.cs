using EcommerceMVC.Enums;

namespace EcommerceMVC.Models.DTO.User
{
    public class CreateUserRequestModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRoleType Role { get; set; }
    }
}
