using EcommerceMVC.Models.DTO.Product;
using System.Collections.Generic;

namespace EcommerceMVC.Models.DTO.User
{
    public class UsersResponseModel:BaseResponse
    {
        public List<UserDTO> Data { get; set; } = new List<UserDTO>();
    }
}
