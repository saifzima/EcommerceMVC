using System;
using System.Collections.Generic;

namespace EcommerceMVC.Models.DTO.Cart
{
    public class CartDTO
    { 
        public int Id { get; set; }
        public DateTime DatePaid{get;set;} 
        public double TotalPrice { get; set; }
        public string RefNo{get;set;}
        public int NumberOfTransaction{get;set;}
        public bool IsPaid { get; set; }
        public int Quantity { get; set; }

    }
}
