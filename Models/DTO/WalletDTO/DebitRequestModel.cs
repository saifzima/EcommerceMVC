using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.WalletDTO
{
    public class DebitRequestModel
    {
         public double Debit { get; set; }
        public string CustomerId { get; set; }
    }
}