using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.WalletDTO
{
    public class WalletDTO
    {
        public double Debit { get; set; }
        public double Credit { get; set; }
        public double Balance { get; set; }
        public string CustomerId { get; set; } 
    }
}