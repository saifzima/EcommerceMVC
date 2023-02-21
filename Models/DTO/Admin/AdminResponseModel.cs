using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.Admin
{
    public class AdminResponseModel : BaseResponse
    {
         public AdminDto Data{get; set;}
    }
    public class AdminsResponseModel : BaseResponse
    {
        public List<AdminDto> Data { get; set; } = new List<AdminDto>();
    }
}