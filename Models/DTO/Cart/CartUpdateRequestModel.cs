using System.Collections.Generic;

namespace EcommerceMVC.Models.DTO.Cart
{
    public class CartUpdateRequestModel
    {
        public int NumberOfTransaction{get;set;}

        public List<Transaction> transaction = new List<Transaction> ();
        public int Quantity { get; set; }
        
    }
}
