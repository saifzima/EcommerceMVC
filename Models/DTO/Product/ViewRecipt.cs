using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models.DTO.Product
{
    public class ViewRecipt 
    {
        public string RefNo{get;set;}
        public int Id{get;set;}
        public DateTime DatePaid{get;set;}
        public int TotalPrice{get;set;}
        public int NumberOfTransaction{get;set;}
        public bool IsPaid{get;set;}
    }
}