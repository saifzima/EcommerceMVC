using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.Wallet
{
    public class WalletResponseModel : BaseResponse
    {
       public WalletDTO Data{get;set;}
    }
     public class WalletsReponseModel : BaseResponse
    {
        public List<WalletDTO> Data{get; set;} = new List<WalletDTO>();
    }
}