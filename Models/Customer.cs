using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models
{
    public class Customers : BaseEntity
    {
        public int Id{get; set;}
        public int UserId { get; set; }
        public User User { get; set; }
        public Wallet Wallets { get; set; }
        public string Address{get; set;}
        public List<Cart> cart = new List<Cart>();
        // public int CartId{get;set;}
        // public Cart Cart{get;set;}
    }
}