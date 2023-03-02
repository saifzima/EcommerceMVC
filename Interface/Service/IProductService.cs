using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceMVC.Models.DTO;
using EcommerceMVC.Models.DTO.Product;

namespace EcommerceMVC.Interface.Service
{
    public interface IProductService
    {
        ProductResponseModel Create(CreateProductRequestModel product);
        BaseResponse Update(ProductUpdateRequestModel product);
        BaseResponse Delete(int RefNo);
        BaseResponse ViewCartByCustomer(ViewRecipt viewRecipt, int userId );
         BaseResponse BuyProduct(BuyRequestModel buyRequest, int userId);
        ProductResponseModel GetById(int RefNo);
       // BuyRequestModel BuyProduct(int ProductId);
        ProductsReponseModel  GetAll();
    }
}