using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.Transation
{
    public class TransationDTO
    {
        
        public DateTime Created { get; set; }
        public string ReferenceNo { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
        public string ProductName { get; set; }

    }
}