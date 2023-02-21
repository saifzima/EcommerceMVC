using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.Transation
{
    public class TransationResponseModel : BaseResponse
    {
         public TransationDTO Data { get; set; }
    }
}