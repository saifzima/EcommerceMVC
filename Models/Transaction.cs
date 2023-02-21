using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models
{
    public class Transaction : BaseEntity
    {
        public int Id{get; set;}
        public int CartId{get;set;}
        public Cart Cart {get;set;}
        public string ProductName { get; set; }
        public string ReferenceNo { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
    }
}