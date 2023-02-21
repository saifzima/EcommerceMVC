using EcommerceMVC.Models.DTO.Admin;

namespace EcommerceMVC.Models.DTO.User
{
    public class UserResponseModel : BaseResponse
    {
        public UserDTO Data { get; set; }
    }
}
