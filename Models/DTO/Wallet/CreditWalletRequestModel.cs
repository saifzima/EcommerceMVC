using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.WalletDTO
{
    public class CreditWalletRequestModel
    {
         public int CustomerId { get; set; }
        public double Credit { get; set; }
    }
}