using System.Collections.Generic;

namespace EcommerceMVC.Models.DTO.Cart
{
    public class CartsResponseModel : BaseResponse
    {
        public List<CartDTO> Data{get; set;} = new List<CartDTO>();
    }
}
