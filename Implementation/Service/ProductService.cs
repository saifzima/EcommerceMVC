using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EcommerceMVC.Interface.IRepository;
using EcommerceMVC.Interface.Service;
using EcommerceMVC.Models;
using EcommerceMVC.Models.DTO;
using EcommerceMVC.Models.DTO.Product;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace EcommerceMVC.Implementation .services
{
    public class ProductService : IProductService
    {
        private readonly  ITransactionRepository  _transaction;
        private readonly IProductRepository _productRepository;
        private readonly ICustomerRepository _customerRepository;
         private readonly IWebHostEnvironment _webpost;
         private readonly IHttpContextAccessor _httpContextAccessor;
        public ProductService(IProductRepository productRepository, IWebHostEnvironment webpost, ITransactionRepository transaction,IHttpContextAccessor httpContextAccessor, ICustomerRepository customerRepository)
        {
            _productRepository = productRepository;
            _webpost = webpost;
            _httpContextAccessor = httpContextAccessor;
            _customerRepository = customerRepository;
            _transaction = transaction;
        }

        public ProductResponseModel Create(CreateProductRequestModel ProductDto)
        {
            var ImageName = "";
           if (ProductDto.Image != null)
           {
               var path = _webpost.WebRootPath;
               var imagepath = Path.Combine(path, "Images");
               Directory.CreateDirectory(imagepath);
               var imagetype = ProductDto.Image.ContentType.Split('/')[1];
               if(imagetype != "png" && imagetype != "jpg" && imagetype != "jpeg")
               {
                   return new ProductResponseModel
                   {
                       Message = "Fail to create product because file type is not image",
                       Status = false
                   };
               }
               ImageName = $"{Guid.NewGuid()}.{imagetype}";
               var fullpath = Path.Combine(imagepath, ImageName);
               using (var stream = new FileStream(fullpath, FileMode.Create))
               {
                    ProductDto.Image.CopyTo(stream);
               }
           }
            var product = new Product
            {
                ProductName = ProductDto.ProductName,
                Price = ProductDto.Price,
                Quality = ProductDto.Quality,
                Quantity = ProductDto.Quantity,
                RefNo = Guid.NewGuid(),
                IsAvailable = true,
                IsDelete = false,
                Image = ImageName,
            };

            var createProduct = _productRepository.Create(product);
            if (createProduct == null)
            {
                return new ProductResponseModel
                {
                    Message = "fail to create",
                    Status = false,
                };
            }
            return new ProductResponseModel
            {
                Data = new ProductDto
                {
                    Id = createProduct.Id,
                    ProductName = createProduct.ProductName,
                    Price = createProduct.Price,
                    Quality = createProduct.Quality,
                    Quantity = createProduct.Quantity,
                    RefNo = createProduct.RefNo
                },
                Message = "Successfully Created",
                Status = true,

            };
        }
        public BaseResponse Delete(int Id)
        {
            var getProduct = _productRepository.GetById(Id);
            if (getProduct == null)
            {
                return new BaseResponse
                {
                    Message = "product does not exist",
                    Status = false,
                };
            }
            var deleteProduct = _productRepository.Delete(getProduct);
            return new BaseResponse
            {
                Message = "deleted",
                Status = true
            };

        }

        public ProductsReponseModel GetAll()
        {
            var getAll = _productRepository.GetAllProduct();
            if (getAll == null)
            {
                return new ProductsReponseModel
                {
                    Message = "failed to fetch",
                    Status = false,
                };
            }
            return new ProductsReponseModel
            {
                Message = "successfully fetched",
                Status = true,
                Data = getAll.Select(x => new ProductDto
                {
                    Id = x.Id,
                    ProductName = x.ProductName,
                    Price = x.Price,
                    Quality = x.Quality,
                    Quantity = x.Quantity,
                    RefNo = x.RefNo,
                    Image = x.Image,
                }).ToList()
            };
        }

        public ProductResponseModel GetById(int RefNo)
        {
            var getById = _productRepository.GetById(RefNo);
            if (getById == null)
            {
                return new ProductResponseModel
                {
                    Message = "Failed to get id",
                    Status = false,
                };
            }
            return new ProductResponseModel
            {
                Message = "successfully fetched",
                Status = true,
                Data = new ProductDto
                {
                    Id = getById.Id,
                    ProductName = getById.ProductName,
                    Price = getById.Price,
                    Quality = getById.Quality,
                    Quantity = getById.Quantity,
                    RefNo = getById.RefNo,
                    Image = getById.Image
                }
            };
        }

        public BaseResponse Update(ProductUpdateRequestModel product)
        {
            var get = _productRepository.GetById(product.Id);
            if (get == null)
            {
                return new BaseResponse
                {
                    Message = "failed to Update",
                    Status = false,
                };
            }
            get.Quantity = product.Quantity;
            get.Price = product.Price;
            _productRepository.Update(get);
            return new BaseResponse
            {
                Message = "successfully Updated",
                Status = true,
            };
        }
        public BaseResponse BuyProduct(BuyRequestModel buyRequest, int userId)
        {
            var get =_productRepository.GetById(buyRequest.Id);
            if(get == null)
            {
                return new BaseResponse
                {
                    Message = "failed to buy",
                    Status = false,
                };   
            }
            if(get.Quantity < buyRequest.Quantity)
            {
                return new BaseResponse
                {
                    Message = "The available quantity is less than the specified quantity",
                    Status = false,
                };  
            }
            var customer = _customerRepository.Get(a => a.UserId == userId);
            get.Quantity -= buyRequest.Quantity;
            get.ProductName = buyRequest.ProductName;
            var transaction = new Transaction
            {
                Quantity =  buyRequest.Quantity ,
                ProductName = buyRequest.ProductName,
                TotalAmount = buyRequest.Price * buyRequest.Quantity,
                Created = DateTime.Now,
                ReferenceNo = Guid.NewGuid().ToString(),                
            };
            var transact = _transaction.Create(transaction);
            return new BaseResponse
            {
                Message = "successfully added to cart",
                Status = true
            };
        }
        // public BaseResponse ViewCartByCustomer()
        // {

        // }
    }
}