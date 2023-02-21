using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.Product
{
    public class ProductUpdateRequestModel
    {
        public double Price {get;set;}
        public int Quantity{get;set;}
        public int Id{get;set;}
    }
}