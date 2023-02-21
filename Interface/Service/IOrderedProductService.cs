using EcommerceMVC.Models.DTO.Admin;
using EcommerceMVC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceMVC.Models.DTO.OrderedProduct;

namespace EcommerceMVC.Interface.Service
{
    public interface IOrderedProductService
    {
        OrderedProductResponseModel Create(CreateOrderedProductRequestModel orderedProductDTO);
        BaseResponse Update(OrderedProductUpdateRequestModel orderedProduct, int orderedProductId);
        BaseResponse Delete(int orderedProductId);
        OrderedProductResponseModel GetById(int orderedProductId);
        OrderedProductsResponseModel GetAll();
    }
}