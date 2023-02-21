using EcommerceMVC.Models.DTO.Product;

namespace EcommerceMVC.Models.DTO.OrderedProduct
{
    public class OrderedProductResponseModel : BaseResponse
    {
        public OrderedProductDTO Data { get; set; }
    }
}
