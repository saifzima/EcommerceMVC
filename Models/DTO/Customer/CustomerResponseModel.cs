using EcommerceMVC.Models.DTO.Product;

namespace EcommerceMVC.Models.DTO.Customer
{
    public class CustomerResponseModel : BaseResponse
    {
        public CustomerDTO Data { get; set; }
    }
}
