using System;
using System.Collections.Generic;

namespace EcommerceMVC.Models
{
    public class Cart: BaseEntity
    {
        public int Id { get; set; }
        public DateTime DatePaid{get;set;} 
        public double TotalPrice { get; set; }
        public int CustomerId{get;set;}
        public Customers Customer{get;set;}
        public string ProductName{get;set;}
        public string RefNo{get;set;} = Guid.NewGuid().ToString();
        public List<Transaction> transaction = new List<Transaction> ();
        public bool IsPaid { get; set; }
    }
}
