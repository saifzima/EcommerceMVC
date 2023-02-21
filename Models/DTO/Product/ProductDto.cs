using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.Product
{
    public class ProductDto
    {
        public int Id{get; set;}
        public string ProductName {get;set;}
        public double Price {get;set;}
        public int Quantity{get;set;}
        public string Quality{get;set;}
        public string Image{get;set;}
        public Guid RefNo {get;set;}
    }
}