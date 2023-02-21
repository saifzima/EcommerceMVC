using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models
{
    public class Wallet
    {
         public int Id { get; set; }
        public Customers Customer { get; set; }
        public int CustomerId { get; set; }
        public double Debit { get; set; }
        public double Credit { get; set; }
        public double Balance { get; set; }
        
    }
}