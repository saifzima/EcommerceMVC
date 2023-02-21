using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.Transation
{
    public class CreateTransationRequestModel
    {
        public int  ProductId{get;set;}
        public string ProductName{get;set;}
        public double Price{get;set;}
        public int UserId { get; set; }
        public int Quantity { get; set; }
    }
}