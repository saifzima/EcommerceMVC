using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceMVC.Models.DTO;
using EcommerceMVC.Models.DTO.Admin;
using EcommerceMVC.Models.DTO.Customer;
using EcommerceMVC.Models.DTO.Transation;

namespace EcommerceMVC.Interface.Service
{
    public interface ICustomerService
    {
        CustomerResponseModel Create(CreateCustomerRequestModel createCustomerRequestModel);
        BaseResponse Update(CustomerUpdateRequestModel customer, int CustomerId);
        BaseResponse Delete(int CustomerId);
        CustomerResponseModel GetById(int CustomerId);
        CustomersResponseModel GetAll();
        FundWalletRequestModel GetBalance(FundWalletRequestModel model, int id); 
    }
}