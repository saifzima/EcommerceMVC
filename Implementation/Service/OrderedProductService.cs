using EcommerceMVC.Implementation.Repository;
using EcommerceMVC.Interface.IRepository;
using EcommerceMVC.Interface.Service;
using EcommerceMVC.Models;
using EcommerceMVC.Models.DTO;
using EcommerceMVC.Models.DTO.OrderedProduct;
using EcommerceMVC.Models.DTO.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Implementation.services
{
    public class OrderedProductService : IOrderedProductService
    {
        private readonly IOrderedProductRepository _orderedProductRepository;
        public OrderedProductService(IOrderedProductRepository orderedProductRepository)
        {
            _orderedProductRepository = orderedProductRepository;
        }

        public OrderedProductResponseModel Create(CreateOrderedProductRequestModel orderedProductDTO)
        {
            var OrderedProduct = new OrderedProduct
            {
                ProductName = orderedProductDTO.ProductName,
                Price = orderedProductDTO.Price,
                Quality = orderedProductDTO.Quality,
                Quantity = orderedProductDTO.Quantity,
            };

            var createOrderedProduct = _orderedProductRepository.Create(OrderedProduct);
            if (createOrderedProduct == null)
            {
                return new OrderedProductResponseModel
                {
                    Message = "fail to create",
                    Status = false,
                };
            }
            return new OrderedProductResponseModel
            {
                Data = new OrderedProductDTO
                {
                    Id = createOrderedProduct.Id,
                    ProductName = createOrderedProduct.ProductName,
                    Price = createOrderedProduct.Price,
                    Quality = createOrderedProduct.Quality,
                    Quantity = createOrderedProduct.Quantity,
                },
                Message = "Successfully Created",
                Status = true,

            };
        }

        public BaseResponse Delete(int orderedProductId)
        {
            var getOrderedProduct = _orderedProductRepository.GetById(orderedProductId);
            if (getOrderedProduct == null)
            {
                return new BaseResponse
                {
                    Message = "OrderedProduct does not exist",
                    Status = false,
                };
            }
            var deleteOrderedProduct = _orderedProductRepository.Delete(getOrderedProduct);
            return new BaseResponse
            {
                Message = "deleted",
                Status = true
            };
        }

        public OrderedProductsResponseModel GetAll()
        {
            var getAll = _orderedProductRepository.GetAllOrderedProduct();
            if (getAll == null)
            {
                return new OrderedProductsResponseModel
                {
                    Message = "failed to fetch",
                    Status = false,
                };
            }
            return new OrderedProductsResponseModel
            {
                Message = "successfully fetched",
                Status = true,
                Data = getAll.Select(x => new OrderedProductDTO
                {
                    ProductName = x.ProductName,
                    Price = x.Price,
                    Quality = x.Quality,
                    Quantity = x.Quantity, 
                    OderedProductsId= x.OderedProductsId,
                }).ToList()
            };
        }

        public OrderedProductResponseModel GetById(int orderedProductId)
        {
            var getById = _orderedProductRepository.GetById(orderedProductId);
            if (getById == null)
            {
                return new OrderedProductResponseModel
                {
                    Message = "Failed to get id",
                    Status = false,
                };
            }
            return new OrderedProductResponseModel
            {
                Message = "successfully fetched",
                Status = true,
            };
        }

        public BaseResponse Update(OrderedProductUpdateRequestModel orderedProduct, int orderedProductId)
        {
            var get = _orderedProductRepository.GetById(orderedProductId);
            if (get == null)
            {
                return new BaseResponse
                {
                    Message = "failed to Update",
                    Status = false,
                };
            }
            get.Quantity = orderedProduct.Quantity;
            get.Price = orderedProduct.Price;
            return new BaseResponse
            {
                Message = "successfully Updated",
                Status = true,
            };
        }
    }
}