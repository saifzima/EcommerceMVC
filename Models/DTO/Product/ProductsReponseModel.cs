using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.Product
{
    public class ProductsReponseModel : BaseResponse
    {
        public List<ProductDto> Data{get; set;} = new List<ProductDto>();
    }
}   