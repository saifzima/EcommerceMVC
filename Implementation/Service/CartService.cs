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
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly IProductRepository _productRepository;
        private readonly ITransactionRepository _transactionRepository;
        private readonly ICustomerRepository _customer;

        public CartService(ICartRepository cartRepository, IProductRepository productRepository,  ITransactionRepository transactionRepository, ICustomerRepository customer)
        {
            _cartRepository = cartRepository;
            _productRepository = productRepository;
            _transactionRepository = transactionRepository;
             _customer = customer;
        }
        
        public BaseResponse Create(CreateTransationRequestModel createTransationRequestModel)
        {
            var customer = _customer.Get(x => x.UserId == createTransationRequestModel.UserId);
             var product = _productRepository.GetById(createTransationRequestModel.ProductId);
                var cart = _cartRepository.Get(x => x.CustomerId == customer.Id && !x.IsPaid);
                if(cart == null)
                {
                    cart = new Cart
                    {
                        CustomerId = customer.Id,
                        TotalPrice = createTransationRequestModel.Price,
                    };
                   cart = _cartRepository.Create(cart);
                }
              var transaction = new Transaction
            {
                Quantity =  createTransationRequestModel.Quantity,
                ProductName = createTransationRequestModel.ProductName,
                TotalAmount = createTransationRequestModel.Price * createTransationRequestModel.Quantity,
                Created = DateTime.Now,
                ReferenceNo = Guid.NewGuid().ToString(),
                CartId = cart.Id
            };

           _transactionRepository.Create(transaction);
           cart.TotalPrice += transaction.TotalAmount;
           _cartRepository.Update(cart);
            product.Quantity -= createTransationRequestModel.Quantity;
            _productRepository.Update(product);
           
            return new BaseResponse
            {
                Message = "successfully added to cart",
                Status = true
            };
        }

       
        public BaseResponse Delete(int Id)
        {
             var getCart = _cartRepository.Get(x => x.Id == Id);
            if (getCart == null)
            {
                return new BaseResponse
                {
                    Message = "Customer does not exist",
                    Status = false,
                };
            }
            var deleteProduct = _cartRepository.Delete(getCart);
            return new BaseResponse
            {
                Message = "deleted",
                Status = true
            };
        }

        public CartsResponseModel GetAll()
        {
            var get = _cartRepository.GetAllCart(x => true);
            if (get == null)
            {
                return new CartsResponseModel
                {
                    Status = false,
                    Message = "Failed to fetch",
                };
            }
            return new CartsResponseModel
            {
                Message = "Successfully fetch",
                Status = true,
                Data = get.Select(x => new CartDTO
                {
                    Id = x.Id,
                    DatePaid = x.DatePaid,
                    TotalPrice = x.TotalPrice,
                    RefNo = x.RefNo,
                    NumberOfTransaction = x.transaction.Count,
                    IsPaid = true,
                }).ToList(),

            };
        }

        public CartResponseModel GetById(int Id)
        {
            var get = _cartRepository.Get(x => x.Id == Id);
            if (get == null)
            {
                return new CartResponseModel
                {
                    Status = false,
                    Message = "Failed to fetch",
                };
            }
            return new CartResponseModel
            {
                Message = "Successfully fetch",
                Status = true
            };        }

        public double GetCartTotal(int Id)
        {
            throw new NotImplementedException();
        }

        public CartResponseModel NotPaidExist(int customerId)
        {
            throw new NotImplementedException();
        }

        public BaseResponse Update(CartUpdateRequestModel cart, int Id)
        {
          var get = _cartRepository.Get(x => x.Id == Id);

            if (get == null)
            {
                return new BaseResponse
                {
                    Message = "failed to Update",
                    Status = false,
                };
            }
            get.transaction = cart.transaction;
            return new BaseResponse
            {
                Message = "successfully Updated",
                Status = true,
            };          
        }
        
        public CartsResponseModel GetCartByCustomer(int userId)
        {
            var customer =_customer.Get(x => x.UserId == userId);
            var get = _cartRepository.GetAllCart(x => x.CustomerId == customer.Id);
            if (get.Count == 0)
            {
                return  new CartsResponseModel
                {
                    Message = "failed to get",
                    Status = false
                };
            }
            return new CartsResponseModel
            {
                Message = "Successfully fetch",
                Status = true,
                Data = get.Select(x => new CartDTO
                {
                    Id = x.Id,
                    DatePaid = x.DatePaid,
                    TotalPrice = x.TotalPrice,
                    RefNo = x.RefNo,
                    NumberOfTransaction = _transactionRepository.GetAllTransaction(t => t.CartId == x.Id).Count,
                    IsPaid = x.IsPaid,
                }).ToList(),
            };
        }
        public TransationsResponseModel GetAllTransactionInCart(int cartId)
        {
            var get = _transactionRepository.GetAllTransaction(x => x.CartId == cartId);
            if(get.Count == 0)
            {
                 return  new TransationsResponseModel
                {
                    Message = "failed to get",
                    Status = false
                };
            }
             return new TransationsResponseModel
            {
                Message = "Successfully fetch",
                Status = true,
                Data = get.Select(x => new TransationDTO
                {
                    ReferenceNo = x.ReferenceNo,
                    ProductName = x.ProductName,
                    Quantity = x.Quantity,
                    TotalAmount = x.TotalAmount,
                    Id = x.Id
                }).ToList(),
            };

        }

        public BaseResponse MakePayment(int id)
        {
             var cart = _cartRepository.Get(x => x.Id == id && !x.IsPaid);
            if(cart == null)
            {
                return new BaseResponse
                {
                    Message = "Cart not found",
                    Status = false,
                };
            }
            cart.IsPaid = true;
            _cartRepository.Update(cart);
            return new BaseResponse
            {
                Message = "Payment successfull",
                Status = true,
            };
        }

        public BaseResponse UpdateTransaction(TransactionUpdateRequestModel transaction)
        {
            var get = _transactionRepository.GetById(transaction.Id);

            if (get == null)
            {
                return new BaseResponse
                {
                    Message = "failed to Update",
                    Status = false,
                };
            }
            get.Quantity= transaction.Quantity;
            _transactionRepository.Update(get);
            return new BaseResponse
            {
                Message = "successfully Updated",
                Status = true,
            };               
       }
    }
}        
       