using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceMVC.Interface.IRepository;
using EcommerceMVC.Interface.Service;
using EcommerceMVC.Models;
using EcommerceMVC.Models.DTO;
using EcommerceMVC.Models.DTO.Cart;
using EcommerceMVC.Models.DTO.Transation;

namespace EcommerceMVC.Implementation.Service
{
    public class TransationService : ITrancsationService
    {
        private readonly ICartRepository _cart;
         private readonly ITransactionRepository _transaction;
        private readonly IProductRepository _product;
        private readonly ICustomerRepository _customer;
         public TransationService(ITransactionRepository transaction, IProductRepository product, ICustomerRepository customer,  ICartRepository cart)
        {
            _transaction = transaction;
            _product = product;
            _customer = customer;
            _cart = cart;
        }
       
        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TransationResponseModel> GetAll()
        {
            throw new NotImplementedException();
        }
        public TransationResponseModel GetById(int Id)
        {
         var getById = _transaction.GetById(Id);
            if (getById == null)
            {
                return new TransationResponseModel
                {
                    Message = "Failed to get id",
                    Status = false,
                };
            }
            return new TransationResponseModel
            {
                Message = "successfully fetched",
                Status = true,
                Data = new TransationDTO
                {
                    Created = getById.Created,
                    CustomerId = getById.Cart.CustomerId,
                    TotalAmount = getById.TotalAmount,
                    ProductName = getById.ProductName,
                    Quantity = getById.Quantity
                },    
            };
        }    
    }
      
}