using EcommerceMVC.Models.DTO.Product;
using System.Collections.Generic;

namespace EcommerceMVC.Models.DTO.OrderedProduct
{
    public class OrderedProductsResponseModel : BaseResponse
    {
        public List<OrderedProductDTO> Data { get; set; } = new List<OrderedProductDTO >();
    }
}
