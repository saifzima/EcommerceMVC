using EcommerceMVC.Models.DTO.Customer;
using System.Collections.Generic;

namespace EcommerceMVC.Models.DTO.DeliveryMan
{
    public class DeliveryMansResponseModel :BaseResponse
    {
        public List<DeliveryManDTO> Data { get; set; } = new List<DeliveryManDTO>();
    }
}
