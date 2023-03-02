using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.Customer
{
    public class FundWalletRequestModel : BaseResponse
    {
        public double Balance{get;set;}
        public int Id{get;set;}
    }
}