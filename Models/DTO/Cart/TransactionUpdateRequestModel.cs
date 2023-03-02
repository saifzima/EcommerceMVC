using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.Cart
{
    public class TransactionUpdateRequestModel
    {
         public string ReferenceNo { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
        public string ProductName { get; set; } 
        public int Id{get;set;}
    }
}