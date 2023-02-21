using EcommerceMVC.Models.DTO.Product;
using System.Collections.Generic;

namespace EcommerceMVC.Models.DTO.Customer
{
    public class CustomersResponseModel :BaseResponse
    {
        public List<CustomerDTO> Data { get; set; } = new List<CustomerDTO>();
    }
}
