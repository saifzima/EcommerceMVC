
using EcommerceMVC.Models.DTO;
using EcommerceMVC.Models.DTO.Cart;
using EcommerceMVC.Models.DTO.Transation;

namespace EcommerceMVC.Interface.Service
{
    public interface ICartService
    {
        BaseResponse Create(CreateTransationRequestModel createTransationRequestModel);
        BaseResponse Update(CartUpdateRequestModel cart, int Id);
        BaseResponse Delete(int Id);
        CartResponseModel GetById(int Id);
        CartsResponseModel GetAll();
        CartsResponseModel GetCartByCustomer(int customerId);
        CartResponseModel NotPaidExist(int Id);
        double GetCartTotal(int Id);
    }
}