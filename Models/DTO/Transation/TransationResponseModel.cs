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
    public class TransationsResponseModel : BaseResponse
    {
         public List<TransationDTO> Data { get; set; } = new List<TransationDTO> ();

    }
}