using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.WalletDTO
{
    public class CreateWalletRequestModel
    {
        public double Debit { get; set; }
        public int CustomerId { get; set; }
        public double Credit { get; set; }
    }
}