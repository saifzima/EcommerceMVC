using System.Collections.Generic;

namespace EcommerceMVC.Models.DTO.Cart
{
    public class CreateCartRequestModel
    {
        public int Id{get;set;}
        public bool IsPaid{get;set;}
        public Customers Customer{get;set;}
        public List<Transaction> transaction = new List<Transaction> ();
        public int Quantity { get; set; }
    }
}
