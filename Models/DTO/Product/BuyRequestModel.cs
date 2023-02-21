using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.Product
{
    public class BuyRequestModel
    {
        public int Id{get;set;}
        public int Quantity{get;set;}
        public int Price{get;set;}
        public string ProductName{get; set;}
    }
}