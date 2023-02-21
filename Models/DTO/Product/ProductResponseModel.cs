using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.Product
{
    public class ProductResponseModel : BaseResponse
    {
        public ProductDto Data{get; set;}
    }
}