using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models
{
    public class OrderedProduct
    {
        public int Id{get;set;}
        [Required]
        public string ProductName{get;set;}
        [Required]
        public double Price{get;set;}
        [Required]
        public int Quantity{get;set;}
        [Required]
        public string Quality{get;set;}
    }
}